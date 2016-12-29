using System;
using Windows.Devices.Gpio;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Core;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            InitGPIO();

        }
        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // GPIO denetleyici yoksa hata uyarı göster
            if (gpio == null)
            {
                GpioStatus.Text = "Denetleyici Yok";
                GpioStatus.Foreground = redBrush;
                return;
            }

            // GPIO Pinleri aç
       //     GPIO02pin = gpio.OpenPin(GPIO02);
       //     GPIO03pin = gpio.OpenPin(GPIO03);
            GPIO04pin = gpio.OpenPin(GPIO04);
            GPIO05pin = gpio.OpenPin(GPIO05);
            GPIO06pin = gpio.OpenPin(GPIO06);
      //      GPIO07pin = gpio.OpenPin(GPIO07);
      //      GPIO08pin = gpio.OpenPin(GPIO08);
      //      GPIO09pin = gpio.OpenPin(GPIO09);
      //      GPIO10pin = gpio.OpenPin(GPIO10);
     //       GPIO11pin = gpio.OpenPin(GPIO11);
            GPIO12pin = gpio.OpenPin(GPIO12);
            GPIO13pin = gpio.OpenPin(GPIO13);
     //       GPIO14pin = gpio.OpenPin(GPIO14);
     //       GPIO15pin = gpio.OpenPin(GPIO15);
            GPIO16pin = gpio.OpenPin(GPIO16);
            GPIO17pin = gpio.OpenPin(GPIO17);
            GPIO18pin = gpio.OpenPin(GPIO18);
            GPIO19pin = gpio.OpenPin(GPIO19);
            GPIO20pin = gpio.OpenPin(GPIO20);
            GPIO21pin = gpio.OpenPin(GPIO21);
            GPIO22pin = gpio.OpenPin(GPIO22);
            GPIO23pin = gpio.OpenPin(GPIO23);
            GPIO24pin = gpio.OpenPin(GPIO24);
            GPIO25pin = gpio.OpenPin(GPIO25);
            GPIO26pin = gpio.OpenPin(GPIO26);
            GPIO27pin = gpio.OpenPin(GPIO27);



// GPIO02 PULL CONTROL
 //           if (GPIO02pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
 //               GPIO02pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
 //           else
 //               GPIO02pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
  //          GPIO02pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
   //         GPIO02pin.ValueChanged += GPIO02_ValueChanged;

            //  




// GPIO03 PULL CONTROL
 //           if (GPIO03pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
  //              GPIO03pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
  //          else
   //             GPIO03pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
   //         GPIO03pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
   //         GPIO03pin.ValueChanged += GPIO03_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO04 PULL CONTROL
            if (GPIO04pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO04pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO04pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO04pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO04pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO05 PULL CONTROL
            if (GPIO05pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO05pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO05pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO05pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO05pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";

            

// GPIO06 PULL CONTROL
            if (GPIO06pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO06pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO06pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO06pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO06pin.ValueChanged += Pin_ValueChanged;

            //       GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO07 PULL CONTROL
   //         if (GPIO07pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
   //             GPIO07pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
   //         else
    //            GPIO07pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
   //         GPIO07pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
   //         GPIO07pin.ValueChanged += GPIO07_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO08 PULL CONTROL
 //           if (GPIO08pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
 //               GPIO08pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
  //          else
 //               GPIO08pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
 //           GPIO08pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
  //          GPIO08pin.ValueChanged += GPIO08_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO09 PULL CONTROL
  //          if (GPIO09pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
  //              GPIO09pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
  //          else
  //              GPIO09pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
  //          GPIO09pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
 //           GPIO09pin.ValueChanged += GPIO09_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO10 PULL CONTROL
  //          if (GPIO10pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
  //              GPIO10pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
 //           else
 //               GPIO10pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
  //          GPIO10pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
  //          GPIO10pin.ValueChanged += GPIO10_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO11 PULL CONTROL
   //         if (GPIO11pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
  //              GPIO11pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
   //         else
  //              GPIO11pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
  //          GPIO11pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
   //         GPIO11pin.ValueChanged += GPIO11_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";



        

// GPIO12 PULL CONTROL
            if (GPIO12pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO12pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO12pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO12pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO12pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO13 PULL CONTROL
            if (GPIO13pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO13pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO13pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO13pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO13pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";
       



// GPIO14 PULL CONTROL
     //       if (GPIO14pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
     //           GPIO14pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
     //       else
     //           GPIO14pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
     //       GPIO14pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
      //      GPIO14pin.ValueChanged += GPIO14_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO15 PULL CONTROL
    //        if (GPIO15pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
    //            GPIO15pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
    //        else
    //            GPIO15pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
    //        GPIO15pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
    //        GPIO15pin.ValueChanged += GPIO15_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO16 PULL CONTROL
            if (GPIO16pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO16pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO16pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO16pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO16pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO17 PULL CONTROL
            if (GPIO17pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO17pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO17pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO17pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO17pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




// GPIO18 PULL CONTROL
            if (GPIO18pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO18pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO18pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO18pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO18pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO19 PULL CONTROL
            if (GPIO19pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO19pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO19pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO19pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO19pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO20 PULL CONTROL
            if (GPIO20pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO20pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO20pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO20pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO20pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO21 PULL CONTROL
            if (GPIO21pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO21pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO21pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO21pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO21pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO22 PULL CONTROL
            if (GPIO22pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO22pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO22pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO22pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO22pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO23 PULL CONTROL
            if (GPIO23pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO23pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO23pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO23pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO23pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO24 PULL CONTROL
            if (GPIO24pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO24pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO24pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO24pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO24pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO25 PULL CONTROL
            if (GPIO25pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO25pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO25pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO25pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO25pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO26 PULL CONTROL
            if (GPIO26pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO26pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO26pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO26pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO26pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





// GPIO27 PULL CONTROL
            if (GPIO27pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO27pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO27pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO27pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO27pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";



        }


        //     private void GPIO02_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //      {
        // toggle the state of the LED every time the button is pressed
        //         if (e.Edge == GpioPinEdge.FallingEdge)
        //         {
        //    PinValue = (PinValue == GpioPinValue.Low) ?
        //   GpioPinValue.High : GpioPinValue.Low;
        //   GPIO02pin.Write(PinValue);

        //}

        // need to invoke UI updates on the UI thread because this event
        // handler gets invoked on a separate thread.
        //     var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //      if (e.Edge == GpioPinEdge.FallingEdge)

        //     {
        //      PinValue = GpioPinValue.Low;
        //     OGPIO02.Fill = redBrush;
        //     Gpio02Status.Text = "Çekiliyor";
        //   }
        //      else
        //     {
        //     OGPIO02.Fill = grayBrush;
        //    Gpio02Status.Text = "Boşta";
        //    }
        //    });
        //    }


        //    private void GPIO03_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //   {
        //        // toggle the state of the LED every time the button is pressed
        //       if (e.Edge == GpioPinEdge.FallingEdge)
        //        {
        //    PinValue = (PinValue == GpioPinValue.Low) ?
        //   GpioPinValue.High : GpioPinValue.Low;
        //  GPIO03pin.Write(PinValue);

        // }

        // need to invoke UI updates on the UI thread because this event
        // handler gets invoked on a separate thread.
        //   var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //           if (e.Edge == GpioPinEdge.FallingEdge)

        //          {
        //  PinValue = GpioPinValue.Low;
        // OGPIO03.Fill = redBrush;
        // Gpio03Status.Text = "Çekiliyor";
        //}
        //         else
        //        {
        // OGPIO03.Fill = grayBrush;
        // Gpio03Status.Text = "Boşta";
        // }
        //   });
        //  }

        private void Pin_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        {
            // need to invoke UI updates on the UI thread because this event
            // handler gets invoked on a separate thread.
            var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
                var PinName = GetPinName(sender.PinNumber);
                var PinTextName = GetPinTextName(sender.PinNumber);
                var PinIcon = MainGrid.FindName(PinName) as Ellipse;
                var PinText = MainGrid.FindName(PinTextName) as TextBlock;

                var test = Gpio04Status;

                if (e.Edge == GpioPinEdge.FallingEdge)
                {
                    PinIcon.Fill = redBrush;
                    PinText.Text = "Çekiliyor";
                }
                else
                {
                    PinIcon.Fill = grayBrush;
                    PinText.Text = "Boşta";
                }
            });
        }

        private string GetPinName(int pinNumber)
        {
            return $"OGPIO{pinNumber:D2}";
        }

        private string GetPinTextName(int pinNumber)
        {
            return $"Gpio{pinNumber:D2}Status";
        }

        //private void GPIO04_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO04pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO04.Fill = redBrush;
        //            Gpio04Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO04.Fill = grayBrush;
        //            Gpio04Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO05_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO05pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO05.Fill = redBrush;
        //            Gpio05Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO05.Fill = grayBrush;
        //            Gpio05Status.Text = "Boşta";
        //        }
        //    });
        //}



        //private void GPIO06_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO06pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO06.Fill = redBrush;
        //            Gpio06Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO06.Fill = grayBrush;
        //            Gpio06Status.Text = "Boşta";
        //        }
        //    });
        //}


        ////   private void GPIO07_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////    {
        //// toggle the state of the LED every time the button is pressed
        ////        if (e.Edge == GpioPinEdge.FallingEdge)
        ////      {
        ////PinValue = (PinValue == GpioPinValue.Low) ?
        ////GpioPinValue.High : GpioPinValue.Low;
        ////GPIO07pin.Write(PinValue);

        ////}

        //// need to invoke UI updates on the UI thread because this event
        //// handler gets invoked on a separate thread.
        ////        var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////              if (e.Edge == GpioPinEdge.FallingEdge)

        ////            {
        ////PinValue = GpioPinValue.Low;
        ////  OGPIO07.Fill = redBrush;
        ////    Gpio07Status.Text = "Çekiliyor";
        ////  }
        ////           else
        ////          {
        ////  OGPIO07.Fill = grayBrush;
        ////  Gpio07Status.Text = "Boşta";
        //// }
        ////   });
        ////  }



        ////    private void GPIO08_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////     {
        //// toggle the state of the LED every time the button is pressed
        ////         if (e.Edge == GpioPinEdge.FallingEdge)
        ////         {
        ////     PinValue = (PinValue == GpioPinValue.Low) ?
        ////  GpioPinValue.High : GpioPinValue.Low;
        ////  GPIO08pin.Write(PinValue);

        //// }

        //// need to invoke UI updates on the UI thread because this event
        //// handler gets invoked on a separate thread.
        ////  var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////          if (e.Edge == GpioPinEdge.FallingEdge)

        ////         {
        //// PinValue = GpioPinValue.Low;
        //// OGPIO08.Fill = redBrush;
        ////  Gpio08Status.Text = "Çekiliyor";
        ////}
        ////      else
        ////      {
        //// OGPIO08.Fill = grayBrush;
        ////  Gpio08Status.Text = "Boşta";
        //// }
        //// });
        //// }


        ////private void GPIO09_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////{
        ////    // toggle the state of the LED every time the button is pressed
        ////    if (e.Edge == GpioPinEdge.FallingEdge)
        ////    {
        ////        PinValue = (PinValue == GpioPinValue.Low) ?
        ////            GpioPinValue.High : GpioPinValue.Low;
        ////        GPIO09pin.Write(PinValue);

        ////    }

        ////    // need to invoke UI updates on the UI thread because this event
        ////    // handler gets invoked on a separate thread.
        ////    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////        if (e.Edge == GpioPinEdge.FallingEdge)

        ////        {
        ////            PinValue = GpioPinValue.Low;
        ////            OGPIO09.Fill = redBrush;
        ////            Gpio09Status.Text = "Çekiliyor";
        ////        }
        ////        else
        ////        {
        ////            OGPIO09.Fill = grayBrush;
        ////            Gpio09Status.Text = "Boşta";
        ////        }
        ////    });
        ////}



        ////private void GPIO10_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////{
        ////    // toggle the state of the LED every time the button is pressed
        ////    if (e.Edge == GpioPinEdge.FallingEdge)
        ////    {
        ////        PinValue = (PinValue == GpioPinValue.Low) ?
        ////            GpioPinValue.High : GpioPinValue.Low;
        ////        GPIO10pin.Write(PinValue);

        ////    }

        ////    // need to invoke UI updates on the UI thread because this event
        ////    // handler gets invoked on a separate thread.
        ////    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////        if (e.Edge == GpioPinEdge.FallingEdge)

        ////        {
        ////            PinValue = GpioPinValue.Low;
        ////            OGPIO10.Fill = redBrush;
        ////            Gpio10Status.Text = "Çekiliyor";
        ////        }
        ////        else
        ////        {
        ////            OGPIO10.Fill = grayBrush;
        ////            Gpio10Status.Text = "Boşta";
        ////        }
        ////    });
        ////}



        ////private void GPIO11_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////{
        ////    // toggle the state of the LED every time the button is pressed
        ////    if (e.Edge == GpioPinEdge.FallingEdge)
        ////    {
        ////        PinValue = (PinValue == GpioPinValue.Low) ?
        ////            GpioPinValue.High : GpioPinValue.Low;
        ////        GPIO11pin.Write(PinValue);

        ////    }

        ////    // need to invoke UI updates on the UI thread because this event
        ////    // handler gets invoked on a separate thread.
        ////    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////        if (e.Edge == GpioPinEdge.FallingEdge)

        ////        {
        ////            PinValue = GpioPinValue.Low;
        ////            OGPIO11.Fill = redBrush;
        ////            Gpio11Status.Text = "Çekiliyor";
        ////        }
        ////        else
        ////        {
        ////            OGPIO11.Fill = grayBrush;
        ////            Gpio11Status.Text = "Boşta";
        ////        }
        ////    });
        ////}



        //private void GPIO12_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO12pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO12.Fill = redBrush;
        //            Gpio12Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO12.Fill = grayBrush;
        //            Gpio12Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO13_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO13pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO13.Fill = redBrush;
        //            Gpio13Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO13.Fill = grayBrush;
        //            Gpio13Status.Text = "Boşta";
        //        }
        //    });
        //}


        ////private void GPIO14_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////{
        ////    // toggle the state of the LED every time the button is pressed
        ////    if (e.Edge == GpioPinEdge.FallingEdge)
        ////    {
        ////        PinValue = (PinValue == GpioPinValue.Low) ?
        ////            GpioPinValue.High : GpioPinValue.Low;
        ////        GPIO14pin.Write(PinValue);

        ////    }

        ////    // need to invoke UI updates on the UI thread because this event
        ////    // handler gets invoked on a separate thread.
        ////    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////        if (e.Edge == GpioPinEdge.FallingEdge)

        ////        {
        ////            PinValue = GpioPinValue.Low;
        ////            OGPIO14.Fill = redBrush;
        ////            Gpio14Status.Text = "Çekiliyor";
        ////        }
        ////        else
        ////        {
        ////            OGPIO14.Fill = grayBrush;
        ////            Gpio14Status.Text = "Boşta";
        ////        }
        ////    });
        ////}



        ////private void GPIO15_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        ////{
        ////    // toggle the state of the LED every time the button is pressed
        ////    if (e.Edge == GpioPinEdge.FallingEdge)
        ////    {
        ////        PinValue = (PinValue == GpioPinValue.Low) ?
        ////            GpioPinValue.High : GpioPinValue.Low;
        ////        GPIO15pin.Write(PinValue);

        ////    }

        ////    // need to invoke UI updates on the UI thread because this event
        ////    // handler gets invoked on a separate thread.
        ////    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        ////        if (e.Edge == GpioPinEdge.FallingEdge)

        ////        {
        ////            PinValue = GpioPinValue.Low;
        ////            OGPIO15.Fill = redBrush;
        ////            Gpio15Status.Text = "Çekiliyor";
        ////        }
        ////        else
        ////        {
        ////            OGPIO15.Fill = grayBrush;
        ////            Gpio15Status.Text = "Boşta";
        ////        }
        ////    });
        ////}



        //private void GPIO16_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO16pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO16.Fill = redBrush;
        //            Gpio16Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO16.Fill = grayBrush;
        //            Gpio16Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO17_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO17pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO17.Fill = redBrush;
        //            Gpio17Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO17.Fill = grayBrush;
        //            Gpio17Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO18_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO18pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO18.Fill = redBrush;
        //            Gpio18Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO18.Fill = grayBrush;
        //            Gpio18Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO19_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO19pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO19.Fill = redBrush;
        //            Gpio19Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO19.Fill = grayBrush;
        //            Gpio19Status.Text = "Boşta";
        //        }
        //    });
        //}



        //private void GPIO20_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO20pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO20.Fill = redBrush;
        //            Gpio20Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO20.Fill = grayBrush;
        //            Gpio20Status.Text = "Boşta";
        //        }
        //    });
        //}



        //private void GPIO21_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO21pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO21.Fill = redBrush;
        //            Gpio21Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO21.Fill = grayBrush;
        //            Gpio21Status.Text = "Boşta";
        //        }
        //    });
        //}



        //private void GPIO22_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO22pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO22.Fill = redBrush;
        //            Gpio22Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO22.Fill = grayBrush;
        //            Gpio22Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO23_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO23pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO23.Fill = redBrush;
        //            Gpio23Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO23.Fill = grayBrush;
        //            Gpio23Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO24_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO24pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO24.Fill = redBrush;
        //            Gpio24Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO24.Fill = grayBrush;
        //            Gpio24Status.Text = "Boşta";
        //        }
        //    });
        //}



        //private void GPIO25_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO25pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO25.Fill = redBrush;
        //            Gpio25Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO25.Fill = grayBrush;
        //            Gpio25Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO26_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO26pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //       //     PinValue = GpioPinValue.Low;
        //            OGPIO26.Fill = redBrush;
        //            Gpio26Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO26.Fill = grayBrush;
        //            Gpio26Status.Text = "Boşta";
        //        }
        //    });
        //}


        //private void GPIO27_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        //{
        //    // toggle the state of the LED every time the button is pressed
        //    if (e.Edge == GpioPinEdge.FallingEdge)
        //    {
        //        PinValue = (PinValue == GpioPinValue.Low) ?
        //            GpioPinValue.High : GpioPinValue.Low;
        //        GPIO27pin.Write(PinValue);

        //    }

        //    // need to invoke UI updates on the UI thread because this event
        //    // handler gets invoked on a separate thread.
        //    var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
        //        if (e.Edge == GpioPinEdge.FallingEdge)

        //        {
        //            PinValue = GpioPinValue.Low;
        //            OGPIO27.Fill = redBrush;
        //            Gpio27Status.Text = "Çekiliyor";
        //        }
        //        else
        //        {
        //            OGPIO27.Fill = grayBrush;
        //            Gpio27Status.Text = "Boşta";
        //        }
        //    });
        //}



    //    private int PinStatus = 0;
        //private const int GPIO02 = 2;
        //private const int GPIO03 = 3;
        private const int GPIO04 = 4;
        private const int GPIO05 = 5;
        private const int GPIO06 = 6;
        //private const int GPIO07 = 7;
        //private const int GPIO08 = 8;
        //private const int GPIO09 = 9;
        //private const int GPIO10 = 10;
        //private const int GPIO11 = 11;
        private const int GPIO12 = 12;
        private const int GPIO13 = 13;
        //private const int GPIO14 = 14;
        //private const int GPIO15 = 15;
        private const int GPIO16 = 16;
        private const int GPIO17 = 17;
        private const int GPIO18 = 18;
        private const int GPIO19 = 19;
        private const int GPIO20 = 20;
        private const int GPIO21 = 21;
        private const int GPIO22 = 22;
        private const int GPIO23 = 23;
        private const int GPIO24 = 24;
        private const int GPIO25 = 25;
        private const int GPIO26 = 26;
        private const int GPIO27 = 27;
        //private GpioPin GPIO02pin;
        //private GpioPin GPIO03pin;
        private GpioPin GPIO04pin;
        private GpioPin GPIO05pin;
        private GpioPin GPIO06pin;
        //private GpioPin GPIO07pin;
        //private GpioPin GPIO08pin;
        //private GpioPin GPIO09pin;
        //private GpioPin GPIO10pin;
        //private GpioPin GPIO11pin;
        private GpioPin GPIO12pin;
        private GpioPin GPIO13pin;
        //private GpioPin GPIO14pin;
        //private GpioPin GPIO15pin;
        private GpioPin GPIO16pin;
        private GpioPin GPIO17pin;
        private GpioPin GPIO18pin;
        private GpioPin GPIO19pin;
        private GpioPin GPIO20pin;
        private GpioPin GPIO21pin;
        private GpioPin GPIO22pin;
        private GpioPin GPIO23pin;
        private GpioPin GPIO24pin;
        private GpioPin GPIO25pin;
        private GpioPin GPIO26pin;
        private GpioPin GPIO27pin;
        private GpioPinValue PinValue = GpioPinValue.High;
    //    private DispatcherTimer timer;
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush yellowBrush = new SolidColorBrush(Windows.UI.Colors.Yellow);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.LightGray);

        private void textBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
