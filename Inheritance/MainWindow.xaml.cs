using System;
using System.Collections.Generic;
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

namespace Inheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventhandlers
        /// <summary>
        /// Handles the Click event of the addBubble control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void addBubble_Click(object sender, RoutedEventArgs e)
        {

            //TODO: 1. Voeg een bubble toe aan het canvas

        }



        #endregion

        private void addBall_Click(object sender, RoutedEventArgs e)
        {
            //TODO: 2. Voeg een ball toe aan het canvas

        }
    }
}
