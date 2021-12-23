using System;
using System.Windows;

namespace WeakEvent
{
    internal class Program
    {
        public class Button
        {
            public event EventHandler Clicked;

            public void Fire()
            {
                Clicked?.Invoke(this, EventArgs.Empty);
            }
        }

        public class Window
        {
            public Window(Button button)
            {
                button.Clicked += ButtonOnClicked;
            }

            private void ButtonOnClicked(object sender, EventArgs eventArgs)
            {
                Console.WriteLine("Button clicked (Window handler)");
            }

            ~Window()
            {
                Console.WriteLine("Window finalized");
            }
        }

        public class WindowWeak
        {
            public WindowWeak(Button button)
            {
                WeakEventManager<Button, EventArgs>
                    .AddHandler(button, "Clicked", ButtonOnClicked);
            }

            private void ButtonOnClicked(object sender, EventArgs eventArgs)
            {
                Console.WriteLine("Button clicked (Window2 handler)");
            }

            ~WindowWeak()
            {
                Console.WriteLine("Window2 finalized");
            }
        }

        static void Main(string[] args)
        {
            var btn = new Button();
            //var window = new Window(btn);
            var windowWeak = new WindowWeak(btn);
            var windowRef = new WeakReference(windowWeak);
            btn.Fire();

            windowWeak = null;

            FireGC();
            Console.WriteLine($"Is Window Alive: {windowRef.IsAlive}");
        }


        private static void FireGC()
        {
            Console.WriteLine("Starting GC");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("GC is done!");
        }
    }
}
