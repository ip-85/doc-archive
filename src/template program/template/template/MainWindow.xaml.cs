using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    

    public  partial class MainWindow : Window
    {
        DataTable table;
        

        public MainWindow()
        {
            InitializeComponent();
            
            UpdateDataGrid(1);

        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid(1);
        }

        private void ShowDocumentsBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid(1);
        }

        private void ShowTagTextBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid(2);
        }

        private void ShowTagsBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid(3);
        }
        private void UpdateDataGrid(int i)
        {
            using (var db = new Model1())
            {
                
                switch (i)
                {
                    case 1: table = db.document.ToListAsync().Result.ToDataTable(); break;
                    case 2: table = db.tag_text.ToListAsync().Result.ToDataTable(); break;
                    case 3: table = db.tag.ToListAsync().Result.ToDataTable(); break;
                }
                 
                gridDocuments.DataContext = table;
            }
        }
    }
    
}
