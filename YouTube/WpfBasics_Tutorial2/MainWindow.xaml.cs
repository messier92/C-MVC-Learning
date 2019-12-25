using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace WpfBasics2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor 


        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region OnLoaded
        /// <summary>
        /// When the application first opens
        /// <param name=sender"></param>
        /// <param name="e"></param>
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Get every logical drive on the machine
            foreach (var drive in Directory.GetLogicalDrives())
            {
                // Create a new item for it
                var item = new TreeViewItem()
                {
                    Header = drive,
                    Tag = drive
                };

                // Listen out for item being expanded
                item.Expanded += Folder_Expanded;

                // Add it to the main tree-view
                FolderView.Items.Add(item);
                item.Items.Add(null);
            }
        }

        /// <summary>
        /// When a folder is expanded, find the sub folders/files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            #region Initial Checks
            var item = (TreeViewItem)sender;

            // If the item only contains dummy item
            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            // Clear dummy data
            item.Items.Clear();

            // Get full path
            var fullPath = (string)item.Tag;

            #endregion

            #region Get Folders
            // Try and get the directories from the folder, ignores any issues doing so
            var directories = new List<string>();
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch { }

            // For each directory...
            directories.ForEach(directoryPath =>
            {
                // Create a subitem
                var subItem = new TreeViewItem()
                {
                    // Set header as folder name
                    Header = GetFileFolderName(directoryPath),
                    // And tag as full path
                    Tag = directoryPath
                };

            // Add dummy items to expand folder
            subItem.Items.Add(null);

            // Handle expanding
            subItem.Expanded += Folder_Expanded;

            // Add subitem to parent
            item.Items.Add(subItem);
            });
            #endregion

            #region Get Files
            // Create a blank list for files
            var files = new List<string>();

            try
            {
                var fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                    files.AddRange(fs);
            }
            catch { }

            files.ForEach(filePath =>
            {
                var subItem = new TreeViewItem()
                {
                    Header = GetFileFolderName(filePath),
                    Tag = filePath
                };
                item.Items.Add(subItem);
            });

            #endregion
        }

        #endregion

        #region Folder Expanded



        #endregion

        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="path">The full path</param>
        /// <returns></returns>
        public static string GetFileFolderName(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
                return string.Empty;

            // Make all slashes to become backslashes
            var normalizedPath = directoryPath.Replace('/', '\\');

            // Find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            // If we don't find a backslash, return the path itself
            if (lastIndex <= 0)
                return directoryPath;

            // Return name after the last backslash
            return directoryPath.Substring(lastIndex + 1);
        }

    }
}
