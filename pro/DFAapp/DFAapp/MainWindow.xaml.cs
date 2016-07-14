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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DFAapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        int balermatha = 0;
        int comboputki = 0;
        int statenumbersputki = 0;
        int acceptedadress = 0;
        string statename = "state";
        private object[] statestore = new object[12];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
         
            int baltop = 60;
            if (comboputki == 0)
            {
                if (balermatha == 0)
                {
                    sob.Text = "baal";
                    var baalstate = new Ellipse();

                    baalstate.Height = 100;
                    baalstate.Width = 100;
                    baalstate.Fill = new SolidColorBrush(Colors.Gray);
                    baalstate.Stroke = new SolidColorBrush(Colors.White);
                    baalstate.StrokeThickness = 3;
                    baalstate.Margin = new Thickness(40, baltop, 0, 0);
                    var text = new TextBlock();
                    text.Margin = new Thickness(70 , 180 , 0 ,0  );
                    text.Text = statename + balermatha.ToString();
                    text.Name = "balerchipa";
              
                    string name = statename + balermatha.ToString();

                    halarpo.Children.Add(text);

                    try
                    {
                        statestore[balermatha] = name;
                    }
                    catch (Exception ex) {
                        sob.Text = ex.ToString() ;
                    }
                    halarpo.Children.Add(baalstate);
                    text.Foreground = new SolidColorBrush(Colors.White);
                   
                    
                }
                if (balermatha == 1)
                {
                    sob.Text = "baal";
                    var baalstate = new Ellipse();

                    baalstate.Height = 100;
                    baalstate.Width = 100;
                    baalstate.Fill = new SolidColorBrush(Colors.Gray);
                    baalstate.Stroke = new SolidColorBrush(Colors.White);
                    baalstate.StrokeThickness = 3;
                    baalstate.Margin = new Thickness(260, baltop, 0, 0);
                    //canva.Children.Add(baalstate);
                    var text = new TextBlock();
                    text.Margin = new Thickness(70+220 , 180,  0, 0);
                    text.Text = statename + balermatha.ToString();
                    text.Foreground = new SolidColorBrush(Colors.White);

                    halarpo.Children.Add(text);

                    halarpo.Children.Add(baalstate);

                    string name = statename + balermatha.ToString();


                    try
                    {
                        statestore[balermatha] = name;
                    }
                    catch (Exception ex)
                    {
                        sob.Text = ex.ToString();
                    }
                    text.Foreground = new SolidColorBrush(Colors.White);

                }
                if (balermatha == 2)
                {
                    sob.Text = "baal";
                    var baalstate = new Ellipse();

                    baalstate.Height = 100;
                    baalstate.Width = 100;
                    baalstate.Fill = new SolidColorBrush(Colors.Gray);
                    baalstate.Stroke = new SolidColorBrush(Colors.White);
                    baalstate.StrokeThickness = 3;
                    baalstate.Margin = new Thickness(480, baltop, 0, 0);
                    //canva.Children.Add(baalstate);
                    var text = new TextBlock();
                    text.Margin = new Thickness(160+350, 180, 0, 0);
                    text.Text = statename + balermatha.ToString();
                    text.Foreground = new SolidColorBrush(Colors.White);

                    halarpo.Children.Add(text);

                    halarpo.Children.Add(baalstate);

                    string name = statename + balermatha.ToString();


                    try
                    {
                        statestore[balermatha] = name;
                    }
                    catch (Exception ex)
                    {
                        sob.Text = ex.ToString();
                    }
                    text.Foreground = new SolidColorBrush(Colors.White);


                }
                if (balermatha == 3)
                {
                    sob.Text = "baal";
                    var baalstate = new Ellipse();

                    baalstate.Height = 100;
                    baalstate.Width = 100;
                    baalstate.Fill = new SolidColorBrush(Colors.Gray);
                    baalstate.Stroke = new SolidColorBrush(Colors.White);
                    baalstate.StrokeThickness = 3;
                    baalstate.Margin = new Thickness(700, baltop, 0, 0);
                    //canva.Children.Add(baalstate);
                    var text = new TextBlock();
                    text.Margin = new Thickness(160+440+120+10, 180, 0, 0);
                    text.Text = statename + balermatha.ToString();
                    text.Foreground = new SolidColorBrush(Colors.White);

                    halarpo.Children.Add(text);

                    halarpo.Children.Add(baalstate);

                    string name = statename + balermatha.ToString();


                    try
                    {
                        statestore[balermatha] = name;
                    }
                    catch (Exception ex)
                    {
                        sob.Text = ex.ToString();
                    }
                    text.Foreground = new SolidColorBrush(Colors.White);

                }
                balermatha = balermatha + 1;
            }
            else
            {
                int kola = 40;
                int begun = 40;
                for (int putkinumber = 1; putkinumber <= statenumbersputki; putkinumber++)
                {
                    
                    int joyerputkitop = 40;
                    sob.Text = "joyer putki";
                    int joyerputkianylise = joyerputkitop+(220*putkinumber);
                    if (putkinumber <= 4) { 

                  
                        int joyerbuchi = 60;
                        var baalstate = new Ellipse();

                        baalstate.Height = 100;
                        baalstate.Width = 100;
                        baalstate.Fill = new SolidColorBrush(Colors.Gray);
                        baalstate.Stroke = new SolidColorBrush(Colors.White);
                        baalstate.StrokeThickness = 3;
                        baalstate.Margin = new Thickness(joyerputkianylise-220, joyerbuchi, 0, 0);
                        //canva.Children.Add(baalstate);
                        halarpo.Children.Add(baalstate);

                    }
                    else if(putkinumber>4 && putkinumber<=8)
                    {
                      
                        int joyerbuchi = 60;
                        var baalstate = new Ellipse();

                        baalstate.Height = 100;
                        baalstate.Width = 100;
                        baalstate.Fill = new SolidColorBrush(Colors.Gray);
                        baalstate.Stroke = new SolidColorBrush(Colors.White);
                        baalstate.StrokeThickness = 3;
                        baalstate.Margin = new Thickness(kola, joyerbuchi+150+10, 0, 0);
                        //canva.Children.Add(baalstate);
                        halarpo.Children.Add(baalstate);
                        kola = kola + 220;
                        sob.Text = "kola dhukse";
                    }
                    else if (putkinumber > 8 && putkinumber<=12)
                    {
                        var baalstate = new Ellipse();

                        baalstate.Height = 100;
                        baalstate.Width = 100;
                        baalstate.Fill = new SolidColorBrush(Colors.Gray);
                        baalstate.Stroke = new SolidColorBrush(Colors.White);
                        baalstate.StrokeThickness = 3;
                        baalstate.Margin = new Thickness(begun, 210 + 150+10, 0, 0);
                        //canva.Children.Add(baalstate);
                        halarpo.Children.Add(baalstate);
                        begun = begun + 220;
                        sob.Text = "begun dhukse go !";
                    }
                    
                }
            }
        }

        private void drawingcombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             comboputki = drawingcombo.SelectedIndex;
            if (comboputki == 0)
            {
                automationdraingstatesnumbertitleputki.Visibility = System.Windows.Visibility.Hidden;
                automationdrawingstateinputputki.Visibility = System.Windows.Visibility.Hidden;
            }
            if (comboputki == 1)
            {
                automationdraingstatesnumbertitleputki.Visibility = System.Windows.Visibility.Visible;
                automationdrawingstateinputputki.Visibility = System.Windows.Visibility.Visible;
            }
           
        }

        private void automationdrawingstateinputputki_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            string balehoga = automationdrawingstateinputputki.Text;
            statenumbersputki = Convert.ToInt16(balehoga);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var putkirbaal = statestore.ElementAt(0);
            output.Text = putkirbaal.ToString();
            startselector.ItemsSource = statestore;
            
            
            Image startstaeimage = new Image();
            BitmapImage si3 = new BitmapImage();
            si3.BeginInit();
            si3.UriSource = new Uri("start.png", UriKind.Relative);
            si3.EndInit();
            startstaeimage.Stretch = Stretch.Fill;
            startstaeimage.Source = si3;
            startstaeimage.Height = 20;
            startstaeimage.Width = 40;
            startstaeimage.Margin = new Thickness(0,100,0,0);
            halarpo.Children.Add(startstaeimage);


            acceptedstate.ItemsSource = statestore;
            int startstateaddress = startselector.SelectedIndex;
            int acceptedstateselector = acceptedstate.SelectedIndex;

            output.Text = statestore[startstateaddress].ToString();
            acceptedstatemarking();
        }
        private void acceptedstatemarking()
        {
            if (acceptedadress == 0)
            {
                sob.Text = "baal";
                var baalstate = new Ellipse();

                baalstate.Height = 80;
                baalstate.Width = 80;
                baalstate.Fill = new SolidColorBrush(Colors.White);
                baalstate.Stroke = new SolidColorBrush(Colors.Black);
                baalstate.StrokeThickness = 1;
                baalstate.Margin = new Thickness(40+10, 60+10, 0, 0);
              
              
                halarpo.Children.Add(baalstate);

                
            }
            if (acceptedadress == 1)
            {
                sob.Text = "baal";
                var baalstate = new Ellipse();

                baalstate.Height = 80;
                baalstate.Width = 80;
                baalstate.Fill = new SolidColorBrush(Colors.White);
                baalstate.Stroke = new SolidColorBrush(Colors.Black);
                baalstate.StrokeThickness = 3;
                baalstate.Margin = new Thickness(260+10, 60+10, 0, 0);


                halarpo.Children.Add(baalstate);

            }
            if (acceptedadress == 2)
            {
                sob.Text = "baal";
                var baalstate = new Ellipse();

                baalstate.Height = 80;
                baalstate.Width = 80;
                baalstate.Fill = new SolidColorBrush(Colors.White);
                baalstate.Stroke = new SolidColorBrush(Colors.Black);
                baalstate.StrokeThickness = 3;
                baalstate.Margin = new Thickness(480+10, 70, 0, 0);


                halarpo.Children.Add(baalstate);

            }
            if (acceptedadress == 3)
            {
                sob.Text = "baal";
                var baalstate = new Ellipse();

                baalstate.Height = 80;
                baalstate.Width = 80;
                baalstate.Fill = new SolidColorBrush(Colors.White);
                baalstate.Stroke = new SolidColorBrush(Colors.Black);
                baalstate.StrokeThickness = 3;
                baalstate.Margin = new Thickness(710, 70, 0, 0);


                halarpo.Children.Add(baalstate);

            }


        }

        private void acceptedstate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            acceptedadress = acceptedstate.SelectedIndex;
        }

        private void startselector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void run_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "run clicked";
        }

        private void test_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "run clicked";
        }

        private void test_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "run clicked";
        }

      

        private void test_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "run clicked";

        }

        private void buildhit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "Build clicked";
            var putkirbaal = statestore.ElementAt(0);
            output.Text = putkirbaal.ToString();
            startselector.ItemsSource = statestore;


            Image startstaeimage = new Image();
            BitmapImage si3 = new BitmapImage();
            si3.BeginInit();
            si3.UriSource = new Uri("start.png", UriKind.Relative);
            si3.EndInit();
            startstaeimage.Stretch = Stretch.Fill;
            startstaeimage.Source = si3;
            startstaeimage.Height = 20;
            startstaeimage.Width = 40;
            startstaeimage.Margin = new Thickness(0, 100, 0, 0);
            halarpo.Children.Add(startstaeimage);


            acceptedstate.ItemsSource = statestore;
            int startstateaddress = startselector.SelectedIndex;
            int acceptedstateselector = acceptedstate.SelectedIndex;

            output.Text = statestore[startstateaddress].ToString();
            acceptedstatemarking();

        }

        private void newhit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sob.Text = "new hit";
            var obj = new MainWindow();
           

        }
        
       
       
      

       
    }
}
