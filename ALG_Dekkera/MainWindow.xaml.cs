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
using System.Timers;
using System.Threading;

namespace ALG_Dekkera
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TB1.IsReadOnly = true;
            TB2.IsReadOnly = true;
            TB3.IsReadOnly = true;
            TB4.IsReadOnly = true;
        }

        #region Variables
        public string[] ListF = new string[3];
        public string ListSTR;
        public int F1 = 0, F2 = 0, F3 = 0;
        public bool FreeZR = true, FreeF1 = true, FreeF2 = true, FreeF3 = true;
        public bool AddF1 = false, AddF2 = false, AddF3 = false;
        public int ZR = 0, ListCount = 0;
        List<string> btnList = new List<string>();
        #endregion Variables

        #region ButtonOpenClose
        void F1False()
        {
            Button1_4.IsEnabled = false;
            Button1_5.IsEnabled = false;
            Button1_6.IsEnabled = false;
            Button1_7.IsEnabled = false;
            Button1_8.IsEnabled = false;
        }
        void F1True()
        {
            Button1_4.IsEnabled = true;
            Button1_5.IsEnabled = true;
            Button1_6.IsEnabled = true;
            Button1_7.IsEnabled = true;
            Button1_8.IsEnabled = true;
        }
        void F2False()
        {
            Button2_4.IsEnabled = false;
            Button2_5.IsEnabled = false;
            Button2_6.IsEnabled = false;
            Button2_7.IsEnabled = false;
            Button2_8.IsEnabled = false;
        }
        void F2True()
        {
            Button2_4.IsEnabled = true;
            Button2_5.IsEnabled = true;
            Button2_6.IsEnabled = true;
            Button2_7.IsEnabled = true;
            Button2_8.IsEnabled = true;
        }
        void F3False()
        {
            Button3_4.IsEnabled = false;
            Button3_5.IsEnabled = false;
            Button3_6.IsEnabled = false;
            Button3_7.IsEnabled = false;
            Button3_8.IsEnabled = false;
        }
        void F3True()
        {
            Button3_4.IsEnabled = true;
            Button3_5.IsEnabled = true;
            Button3_6.IsEnabled = true;
            Button3_7.IsEnabled = true;
            Button3_8.IsEnabled = true;
        }
        void ButtonTrue()
        { F1True(); F2True(); F3True(); }
        void MsgWait()
        {
            TB1.Text = "Waiting... ... ...";
            TB2.Text = "Waiting... ... ...";
            TB3.Text = "Waiting... ... ...";
        }
        void AddFReset()
        {
            AddF1 = false; AddF2 = false; AddF3 = false;
        }
        #endregion ButtonOpenClose

        #region F1
        private void Button_Click_2(object sender, RoutedEventArgs e) //установка 1 
        {
            F1 = 1;
            if (AddF1 == false)
            {
                TB1.Text = "F1 установлено значение: " + F1.ToString();
                btnList.Add("F1");
                if (TB4.Text == "List очищен!") { TB4.Text = ""; }
                TB4.Text += "В List внесено значение: F1\n";
                AddF1 = true;
            }
            else MessageBox.Show("Ранее уже установлено значение для F1\nВыполните прогон программы до конца и задайте значение заново.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
        private void Button_Click(object sender, RoutedEventArgs e)// проверка 1
        {
            if (F2 == 0 && F3 == 0) TB1.Text = "F2 и F3 не намерены войти в критический участок";

            else if (F2 == 1 && F3 == 1) TB1.Text = "F2 и F3 намерены войти в критический участок";
            else if (F2 == 0 && F3 == 1) TB1.Text = "F3 намерен войти в критический участок\nF2 не намерен войти в критический участок";
            else if (F2 == 1 && F3 == 0) TB1.Text = "F2 намерен войти в критический участок\nF3 не намерен войти в критический участок";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) // проверка zr
        {
            if (FreeZR == true)
            {
                TB1.Text = "ZR cвободен для установка F1. Значение = " + ZR.ToString();
            }
            else
                TB1.Text = "ZR занят. Значение = " + ZR.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //установка zr
        {
            MsgWait();
            if (F1 != 0)
            {
                if (FreeZR == true)
                {
                    ZR = 1;
                    FreeZR = false;
                    FreeF1 = false;
                    TB1.Text = "ZR = " + ZR.ToString();
                }
                else TB1.Text = "Error 01. ZR занят! Значение = " + ZR.ToString();
            }
            else TB1.Text = "Error 02. F1 не установлен!";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // вход в кр уч 1
        {
            MsgWait();
            if (FreeF1 == false)
            {
                TB1.Text = "F1 вошёл в критический участок";
            }
            else TB1.Text = "F1 не может войти в критический участок т.к. он занят";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)// выход  из кр уч 1
        {
            MsgWait();
            if (FreeF1 == false)
            {
                TB1.Text = "F1 вышел из критического участка";
            }
            else TB1.Text = "F1 не входил в ранее в критический участок";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)// сброс zr
        {
            MsgWait();
            if (FreeF1 == false)
            {
                ZR = 0;
                FreeZR = true;
                FreeF1 = true;
                TB1.Text = "ZR сброшен и равен " + ZR.ToString();
            }
            else
                if (FreeZR == true)
            {
                TB1.Text = "ZR ранее не занимали. Значение: " + ZR.ToString();
            }
            else
                TB1.Text = "ZR был занят ранее другим, его не может отменить F1";

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)// сброс f1
        {
            F1 = 0;
            TB1.Text = "F1 cброшен: " + F1.ToString();
            ListCount++;
            if (btnList.Count == 3)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString() + btnList[2].ToString();

                if (F2 != 0)
                {
                    if (ListSTR == "F1F2F3" || ListSTR == "F2F1F3" || ListSTR == "F2F3F1") { F2True(); F3False(); F1False(); }
                }
                else { F3True(); F2False(); F1False(); }

                if (F3 != 0)
                {
                    if (ListSTR == "F1F3F2" || ListSTR == "F3F1F2" || ListSTR == "F3F2F1") { F3True(); F2False(); F1False(); }
                }
                else { F2True(); F3False(); F1False(); }

                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString() + " -> " + btnList[2].ToString();
            }

            else if (btnList.Count == 2)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString();
                if (ListSTR == "F1F2" || ListSTR == "F2F1") { F1False(); F2True(); F3False(); }
                else if (ListSTR == "F1F3" || ListSTR == "F3F1") { F1False(); F3True(); F2False(); }
                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString();
            }

            if (ListCount == 3 && btnList.Count == 3) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
            if (ListCount == 2 && btnList.Count == 2) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
        }
        #endregion F1

        #region F2

        private void Button_Click_8(object sender, RoutedEventArgs e) //1
        {
            F2 = 1;
            if (AddF2 == false)
            {
                TB2.Text = "F2 установлено значение: " + F2.ToString();
                btnList.Add("F2");
                if (TB4.Text == "List очищен!") { TB4.Text = ""; }
                TB4.Text += "В List внесено значение: F2\n";
                AddF2 = true;
            }
            else MessageBox.Show("Ранее уже установлено значение для F2\nВыполните прогон программы до конца и задайте значение заново.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //2 
        {
            if (F1 == 0 && F3 == 0) TB2.Text = "F1 и F3 не намерены войти в критический участок";

            else if (F1 == 1 && F3 == 1) TB2.Text = "F1 и F3 намерены войти в критический участок";
            else if (F1 == 0 && F3 == 1) TB2.Text = "F3 намерен войти в критический участок\nF1 не намерен войти в критический участок";
            else if (F1 == 1 && F3 == 0) TB2.Text = "F1 намерен войти в критический участок\nF3 не намерен войти в критический участок";
        }
        private void Button_Click_11(object sender, RoutedEventArgs e) //3
        {
            if (FreeZR == true)
            {
                TB2.Text = "ZR cвободен для установка F2. Значение = " + ZR.ToString();
            }
            else
                TB2.Text = "ZR занят. Значение = " + ZR.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //4 
        {
            MsgWait();
            if (F2 != 0)
            {
                if (FreeZR == true)
                {
                    ZR = 1;
                    FreeZR = false;
                    FreeF2 = false;
                    TB2.Text = "ZR = " + ZR.ToString();
                }
                else TB2.Text = "Error 01. ZR занят F1! Значение = " + ZR.ToString();
            }
            else TB2.Text = "Error 02. F2 не установлен!";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //5
        {
            MsgWait();
            if (FreeF2 == false)
            {
                TB2.Text = "F2 вошёл в критический участок";
            }
            else TB2.Text = "F2 не может войти в критический участок т.к. он занят";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) //6
        {
            MsgWait();
            if (FreeF2 == false)
            {
                TB2.Text = "F2 вышел из критического участка";
            }
            else TB2.Text = "F2 не входил в ранее в критический участок";
        }


        private void Button_Click_14(object sender, RoutedEventArgs e) //7
        {
            MsgWait();
            if (FreeF2 == false)
            {
                ZR = 0;
                FreeZR = true;
                FreeF2 = true;
                TB2.Text = "ZR сброшен и равен " + ZR.ToString();
            }
            else
            if (FreeZR == true)
            {
                TB2.Text = "ZR ранее не занимали. Значение: " + ZR.ToString();
            }
            else
                TB2.Text = "ZR был занят ранее другим, его не может отменить F2";

        }

        private void Button_Click_15(object sender, RoutedEventArgs e) //8
        {
            F2 = 0;
            TB2.Text = "F2 cброшен: " + F2.ToString();
            ListCount++;
            if (btnList.Count == 3)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString() + btnList[2].ToString();

                if (F1 != 0)
                {
                    if (ListSTR == "F1F2F3" || ListSTR == "F2F1F3" || ListSTR == "F1F3F2") { F1True(); F2False(); F3False(); }
                }
                else { F3True(); F2False(); F1False(); }
                if (F3 != 0)
                {
                    if (ListSTR == "F3F2F1" || ListSTR == "F2F3F1" || ListSTR == "F3F1F2") { F3True(); F2False(); F1False(); }
                }
                else { F1True(); F2False(); F3False(); }
                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString() + " -> " + btnList[2].ToString();
            }
            else if (btnList.Count == 2)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString();
                if (ListSTR == "F1F2" || ListSTR == "F2F1") { F2False(); F1True(); F3False(); }
                else if (ListSTR == "F2F3" || ListSTR == "F3F2") { F2False(); F3True(); F2False(); }
                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString();
            }

            if (ListCount == 3 && btnList.Count == 3) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
            if (ListCount == 2 && btnList.Count == 2) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
        }

        #endregion F2

        #region F3

        private void Button_Click_16(object sender, RoutedEventArgs e) // уставнока f3
        {
            F3 = 1;
            if (AddF3 == false)
            {
                TB3.Text = "F1 установлено значение: " + F3.ToString();
                btnList.Add("F3");
                if (TB4.Text == "List очищен!") { TB4.Text = ""; }
                TB4.Text += "В List внесено значение: F3\n";
                AddF3 = true;
            }
            else MessageBox.Show("Ранее уже установлено значение для F3\nВыполните прогон программы до конца и задайте значение заново.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }



        private void Button_Click_17(object sender, RoutedEventArgs e) // проверка f3
        {
            if (F1 == 0 && F2 == 0) TB3.Text = "F1 и F2 не намерены войти в критический участок";

            else if (F1 == 1 && F2 == 1) TB3.Text = "F1 и F2 намерены войти в критический участок";
            else if (F1 == 0 && F2 == 1) TB3.Text = "F2 намерен войти в критический участок\nF1 не намерен войти в критический участок";
            else if (F1 == 1 && F2 == 0) TB3.Text = "F1 намерен войти в критический участок\nF2 не намерен войти в критический участок";

        }

        private void Button_Click_18(object sender, RoutedEventArgs e) // проверка zr
        {
            if (FreeZR == true)
            {
                TB3.Text = "ZR cвободен для установка F3. Значение = " + ZR.ToString();
            }
            else
                TB3.Text = "ZR занят. Значение = " + ZR.ToString();
        }


        private void Button_Click_19(object sender, RoutedEventArgs e) // установка zr
        {
            MsgWait();
            if (F3 != 0)
            {
                if (FreeZR == true)
                {
                    ZR = 1;
                    FreeZR = false;
                    FreeF3 = false;
                    TB3.Text = "ZR = " + ZR.ToString();
                }
                else TB3.Text = "Error 01. ZR занят! Значение = " + ZR.ToString();
            }
            else TB3.Text = "Error 02. F3 не установлен!";
        }

        private void Button_Click_20(object sender, RoutedEventArgs e) // вход в кр уч
        {
            MsgWait();
            if (FreeF3 == false)
            {
                TB3.Text = "F3 вошёл в критический участок";
            }
            else TB3.Text = "F3 не может войти в критический участок т.к. он занят";
        }

        private void Button_Click_21(object sender, RoutedEventArgs e) // выход из кр уч
        {
            MsgWait();
            if (FreeF3 == false)
            {
                TB3.Text = "F3 вышел из критического участка";
            }
            else TB3.Text = "F3 не входил в ранее в критический участок";
        }

        private void Button_Click_22(object sender, RoutedEventArgs e) // сброс  zr
        {
            MsgWait();
            if (FreeF3 == false)
            {
                ZR = 0;
                FreeZR = true;
                FreeF3 = true;
                TB3.Text = "ZR сброшен и равен " + ZR.ToString();
            }
            else
            if (FreeZR == true)
            {
                TB3.Text = "ZR ранее не занимали. Значение: " + ZR.ToString();
            }
            else TB3.Text = "ZR был занят ранее другим, его не может отменить F3";
        }

        private void Button_Click_23(object sender, RoutedEventArgs e) // сброс f3
        {
            F3 = 0;
            TB3.Text = "F3 cброшен: " + F3.ToString();
            ListCount++;
            if (btnList.Count == 3)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString() + btnList[2].ToString();

                if (F2 != 0)
                {
                    if (ListSTR == "F2F1F3" || ListSTR == "F2F3F1" || ListSTR == "F3F2F1") { F2True(); F1False(); F3False(); }
                }
                else { F1True(); F2False(); F3False(); }
                if (F1 != 0)
                {
                    if (ListSTR == "F1F2F3" || ListSTR == "F1F3F2" || ListSTR == "F3F1F2") { F1True(); F2False(); F3False(); }
                }
                else { F2True(); F1False(); F3False(); }
                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString() + " -> " + btnList[2].ToString();
            }

            else if (btnList.Count == 2)
            {
                ListSTR = btnList[0].ToString() + btnList[1].ToString();
                if (ListSTR == "F1F3" || ListSTR == "F3F1") { F3False(); F1True(); F2False(); }
                else if (ListSTR == "F2F3" || ListSTR == "F3F2") { F3False(); F2True(); F1False(); }
                TB4.Text = "Очерёдность:\n" + btnList[0].ToString() + " -> " + btnList[1].ToString();
            }

            if (ListCount == 3 && btnList.Count == 3) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
            if (ListCount == 2 && btnList.Count == 2) { btnList.Clear(); ListCount = 0; TB4.Text = "List очищен!"; ButtonTrue(); AddFReset(); }
        }
        #endregion F3
    }

}
