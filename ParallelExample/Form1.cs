using System;
using System.Diagnostics;

namespace ParallelExample
{
    public partial class Form1 : Form
    {
        private Stopwatch watch;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Synchronous Execution:
        /// Tasks are performed sequentially, potentially blocking the GUI thread and causing unresponsiveness.
        /// </summary>
        private void BtnSyncClicked(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            StartLongRunningOperations();

            Method1();
            Method2();
            Method3();
            Method4();

            CompleteLongRunningOperations();
        }

        /// <summary>
        /// Asynchronous Execution:
        /// Tasks are executed in the background, allowing the GUI to remain responsive while waiting for completion.
        /// </summary>
        private async void BtnAsyncClicked(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            StartLongRunningOperations();

            await Method1Async();
            await Method2Async();
            await Method3Async();
            await Method4Async();

            CompleteLongRunningOperations();
        }

        /// <summary>
        /// Parallel Execution:
        /// Multiple tasks run concurrently, leveraging multi-core processors to potentially expedite processing.
        /// Please note that this can only be used on a group of methods that do not depend on eachother.
        /// </summary>
        private async void BtnParallellClicked(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            StartLongRunningOperations();

            var tasks = new List<Task>
            {
                Method1Async(),
                Method2Async(),
                Method3Async(),
                Method4Async()
            };

            // Wait on this line until all tasks are completed
            await Task.WhenAll(tasks);

            CompleteLongRunningOperations();
        }

        private void ClearScreen()
        {
            txtResult.Text = string.Empty;
        }

        private void Method1()
        {
            Thread.Sleep(4000);
            ReportCompletion(nameof(Method1));
        }

        // When using async, we use Task instead of void
        private async Task Method1Async()
        {
            // Task Run -> Force synchronous code to run on different threads
            await Task.Run(() => Thread.Sleep(4000));
            ReportCompletion(nameof(Method1Async));
        }

        private void Method2()
        {
            Thread.Sleep(2000);
            ReportCompletion(nameof(Method2));
        }

        private async Task Method2Async()
        {
            // Prefer to use built-in async methods over forcing sync code to run async
            await Task.Delay(2000);
            ReportCompletion(nameof(Method2Async));
        }

        private void Method3()
        {
            Thread.Sleep(3500);
            ReportCompletion(nameof(Method3));
        }

        private async Task Method3Async()
        {
            await Task.Delay(3500);
            ReportCompletion(nameof(Method3Async));
        }

        private void Method4()
        {
            Thread.Sleep(1000);
            ReportCompletion(nameof(Method4));
        }

        private async Task Method4Async()
        {
            await Task.Delay(1000);
            ReportCompletion(nameof(Method4Async));
        }

        private void ReportCompletion(string method)
        {
            txtResult.Text += $"{method} has been completed, ({watch.ElapsedMilliseconds} ms). {Environment.NewLine}";
        }

        private void StartLongRunningOperations()
        {
            ClearScreen();
            txtResult.Text += $"Launching...{Environment.NewLine}";
        }

        private void CompleteLongRunningOperations()
        {
            txtResult.Text += $"Done.{Environment.NewLine}";
            txtResult.Text += $"Elapsed time: {watch.ElapsedMilliseconds}";
        }
    }
}