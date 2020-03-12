using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Prueba.Utilidades
{
    public static class ChangesColors
    {
        public static void CreateStruct(bool mode)
        {
            App.Current.Resources.Add("DefaultColor", Color.FromHex("#2196F3"));
            App.Current.Resources.Add("Dark", Color.FromHex("#2a2828"));
            App.Current.Resources.Add("DarkModeGray", Color.Gray);
            App.Current.Resources.Add("lvColor", Color.White);
            
            if (mode)
            {
                Style TimePickerStyle = new Style(typeof(TimePicker))
                {
                    Setters =
                    {
                        new Setter { Property = TimePicker.BackgroundColorProperty, Value = Color.Gray},
                        new Setter { Property = TimePicker.TextColorProperty, Value = Color.White}
                    }
                };

                Style DatePickerStyle = new Style(typeof(DatePicker))
                {
                    Setters =
                    {
                        new Setter { Property = DatePicker.BackgroundColorProperty, Value = Color.Gray},
                        new Setter { Property = DatePicker.TextColorProperty, Value = Color.Black}
                    }
                };
                Style SwitchStyle = new Style(typeof(Switch))
                {
                    Setters =
                    {
                        new Setter{ Property = Switch.BackgroundColorProperty, Value = Color.White},
                        new Setter { Property = Switch.OnColorProperty, Value = Color.Gray}
                    }
                };
                Style CheckBoxStyle= new Style(typeof(CheckBox))
                {
                    Setters =
                    {
                       
                        new Setter { Property = CheckBox.ColorProperty, Value = Color.Gray}
                    }
                };
                Style DarkPicker = new Style(typeof(Picker))
                {
                    Setters =
                    {
                        new Setter { Property = Picker.BackgroundColorProperty, Value = Color.White},
                        new Setter { Property = Picker.TextColorProperty, Value = Color.Gray},
                        new Setter { Property = Picker.TitleColorProperty, Value=Color.White}
                    }
                };
                Style Navigation = new Style(typeof(NavigationPage))
                {
                    Setters =
                    {
                        new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value=Color.Gray},
                        new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.White},
                        new Setter { Property = NavigationPage.BackgroundColorProperty, Value=App.Current.Resources["Dark"]}
                    }
                };    
                
                Style labels = new Style(typeof(Label))
                {
                    Setters = {
                        new Setter { Property = Label.TextColorProperty,   Value = Color.White }
                    }

                };
                Style buttons = new Style(typeof(Button))
                {
                    Setters =
                    {
                        new Setter { Property = Button.BorderColorProperty, Value = Color.Black},
                        new Setter { Property = Button.BackgroundColorProperty, Value = Color.DarkGray},
                        new Setter { Property = Button.TextColorProperty, Value = Color.Black}
                    }
                    
                };
               

                Style entries = new Style(typeof(Entry))
                {
                    Setters =
                    {
                          new Setter { Property = Entry.BackgroundColorProperty, Value=App.Current.Resources["DarkModeGray"]}
                    }
                };
                App.Current.Resources.Add(Navigation);
                App.Current.Resources.Add(labels);
                App.Current.Resources.Add(buttons);
                App.Current.Resources.Add(entries);
                App.Current.Resources.Add(DarkPicker);
                App.Current.Resources.Add(CheckBoxStyle);
                App.Current.Resources.Add(SwitchStyle);
                App.Current.Resources.Add(TimePickerStyle);
                App.Current.Resources.Add(DatePickerStyle);
            }
            else
            {
               
                Style Navigation = new Style(typeof(NavigationPage))
                {
                    Setters =
                    {
                        new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value=App.Current.Resources["DefaultColor"]},
                        new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.White},
                        new Setter { Property = NavigationPage.BackgroundColorProperty, Value=Color.White}
                    }
                };

                Style buttons = new Style(typeof(Button))
                {
                    Setters =
                    {
                        new Setter { Property = Button.BorderColorProperty, Value = Color.Black},
                        new Setter { Property = Button.BackgroundColorProperty, Value = Color.White},
                        new Setter { Property = Button.TextColorProperty, Value = Color.Black}
                    }

                };
                Style NormalPicker = new Style(typeof(Picker))
                {
                    Setters =
                    {
                        new Setter { Property = Picker.BackgroundColorProperty, Value = Color.White},
                        new Setter { Property = Picker.TextColorProperty, Value = Color.Black},
                        new Setter { Property = Picker.TitleColorProperty, Value=Color.Black}
                    }
                };
                App.Current.Resources.Add(Navigation);
                App.Current.Resources.Add(NormalPicker);
                App.Current.Resources.Add(buttons);
                App.Current.Resources["lvColor"] = Color.Black;
            }
          
       
        }
        public static void ChangeToDark()
        {
            (App.Current.MainPage as NavigationPage).BackgroundColor = (Color)App.Current.Resources["Dark"];
            (App.Current.MainPage as NavigationPage).BarTextColor = Color.White;
            (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.Gray;

            App.Current.Resources["Xamarin.Forms.Picker"] = new Style(typeof(Picker))
            {
                Setters =
                {
                    new Setter { Property = Picker.BackgroundColorProperty, Value = Color.White},
                    new Setter { Property = Picker.TextColorProperty, Value = Color.Gray},
                    new Setter { Property = Picker.TitleColorProperty, Value=Color.White}
                }
            };

            App.Current.Resources["Xamarin.Forms.CheckBox"] = new Style(typeof(CheckBox))
            {
                Setters =
                {
                    new Setter { Property = CheckBox.ColorProperty, Value = Color.Gray}
                }
            };
            App.Current.Resources["Xamarin.Forms.Label"] = new Style(typeof(Label))
            {
                Setters = {
                        new Setter { Property = Label.TextColorProperty,   Value = Color.White }
                }

            };

            App.Current.Resources["Xamarin.Forms.Button"] = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BorderColorProperty, Value = Color.Black},
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.DarkGray},
                    new Setter { Property = Button.TextColorProperty, Value = Color.Black}

                }
            };

            App.Current.Resources["Xamarin.Forms.Entry"] = new Style(typeof(Entry))
            {
                Setters =
                {
                    new Setter { Property = Entry.BackgroundColorProperty, Value=App.Current.Resources["DarkModeGray"]}
                }
            };
            App.Current.Resources["lvColor"] = Color.White;
        }

        public static void ChangeToDefault()
        {

            (App.Current.MainPage as NavigationPage).BackgroundColor = Color.White;
            (App.Current.MainPage as NavigationPage).BarTextColor = Color.White;
            (App.Current.MainPage as NavigationPage).BarBackgroundColor =(Color)App.Current.Resources["DefaultColor"];

            App.Current.Resources["Xamarin.Forms.Picker"] = new Style(typeof(Picker))
            {
                Setters =
                {
                    new Setter { Property = Picker.BackgroundColorProperty, Value = Color.White},
                    new Setter { Property = Picker.TextColorProperty, Value = Color.Black},
                    new Setter { Property = Picker.TitleColorProperty, Value=Color.Black}
                }
            };

            App.Current.Resources["Xamarin.Forms.CheckBox"] = new Style(typeof(CheckBox))
            {
                Setters =
                {
                   
                    new Setter { Property = CheckBox.ColorProperty, Value = Color.Blue}
                }
            };

            App.Current.Resources["Xamarin.Forms.Label"] = new Style(typeof(Label))
            {
                Setters = {
                        new Setter { Property = Label.TextColorProperty,   Value = Color.Black }
                }

            };

            App.Current.Resources["Xamarin.Forms.Button"] = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BorderColorProperty, Value = Color.Black},
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.White},
                    new Setter { Property = Button.TextColorProperty, Value = Color.Black}

                }
            };

            App.Current.Resources["Xamarin.Forms.Entry"] = new Style(typeof(Entry))
            {
                Setters =
                {
                    new Setter { Property = Entry.BackgroundColorProperty, Value=Color.White}
                }
            };
            App.Current.Resources["lvColor"] = Color.Black;
        }
    }
}
