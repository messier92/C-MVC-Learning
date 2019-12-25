using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfBasics2.Directory.Data;

namespace WpfBasics2.Directory.ViewModels
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        #region Public Properties

   
        /// <summary>
        /// The type of this item
        /// </summary>
        public DirectoryItemType Type { get; set; }
        /// <summary>
        /// The absolute path to the item
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// The name of this directory item
        /// </summary>
        public string Name { get { return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }

        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }

        #endregion

        #region Public Commands

        public ICommand ExpandCommand { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {
            this.ExpandCommand = new RelayCommand(Expand);

            this.FullPath = fullPath;
            this.Type = type;

            // Setup children as eneded
            this.ClearChildren();
        }
        #endregion

        #region Helper Methods
        public bool IsExpanded
        {
            get
            {
                return this.Children?.Count(f => f != null) > 0;
            }
            set
            {
                // If the UI tells us to expand
                if (value == true)
                    // Find all children
                    Expand();
                else
                    // If the UI tells us to close
                    this.ClearChildren();
            }
        }

        #endregion

        /// <summary>
        /// Removes all children from the list, adding a dummy icon to show the expand icon if required
        /// </summary>
        private void ClearChildren()
        {
            // Clear items
            this.Children = new ObservableCollection<DirectoryItemViewModel>();

            // If the type is not a file, show the expand arrow
            if (this.Type != DirectoryItemType.File)
                this.Children.Add(null);
        }

        private void Expand()
        {
            if (this.Type == DirectoryItemType.File)
                return;

            // Find all chuldren when expand
            this.Children = new ObservableCollection<DirectoryItemViewModel> 
                (DirectoryStructure.GetDirectoryContents(this.FullPath).Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }
    }
}
