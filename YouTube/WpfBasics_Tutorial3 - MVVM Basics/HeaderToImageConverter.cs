using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WpfBasics2.Directory;
using WpfBasics2.Directory.Data;

namespace WpfBasics2
{
    [ValueConversion(typeof(DirectoryItemType), typeof(BitmapImage))]
    /// <summary>
    /// Converts a full path to a specific image type of a drive, folder or file
    /// </summary>
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Set the default image
            var image = "file.png";

            switch((DirectoryItemType)value)
            {
                case DirectoryItemType.Drive:
                    image = "drive.png";
                    break;
                case DirectoryItemType.Folder:
                    image = "folder-closed.png";
                    break;
                case DirectoryItemType.File:
                    image = "file.png";
                    break;
            }
    
            return new BitmapImage(new Uri($"pack://application:,,,/Images/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
