using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace System_programming_Semaphore_Homework
{
    public partial class Form1 : Form
    {

        // Fields

        public List<string> createdthreads = new();
        public List<string> workingthreads = new();
        public List<string> waitingthreads = new();
        public List<Thread> Threads = new();
        public int currentThreadId = 0;

        // Constructor

        public Form1()
        {
            InitializeComponent();
        }

        // Functions

        //private void button1_Click(object sender, EventArgs e)
        //{


        //    Thread thread = new Thread(Method);
        //    createdthreads.Add("Thread " + thread.ManagedThreadId);
        //    Threads.Add(thread);
        //    CreatedThreads.Items.Add("Thread " + thread.ManagedThreadId);
        //}

        //private void Method(object? semaphore)
        //{

        //    Semaphore Semaphore = semaphore as Semaphore;

        //    if (semaphore == null) return;
        //    bool isFinish = false;

        //    while (!isFinish)
        //    {

        //        if (Semaphore.WaitOne(2000))
        //        {

        //            try
        //            {

        //                CreatedThreads.Items.Remove("Thread " + Threads[currentThreadId].ManagedThreadId);
        //                WaitingThreads.Items.Add("Thread " + Threads[currentThreadId].ManagedThreadId);
        //                currentThreadId += 1;
        //                Thread.Sleep(6000);
        //            }
        //            finally
        //            {

        //                isFinish = true;
        //                WaitingThreads.Items.Remove("Thread " + Threads[currentThreadId - 1].ManagedThreadId);
        //                WorkingThreads.Items.Add("Thread " + Threads[currentThreadId - 1].ManagedThreadId);
        //                currentThreadId -= 1;
        //                Semaphore.Release();
        //            }
        //        }
        //    }
        //}

        //private void CreatedThreads_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    Semaphore semaphore = new Semaphore(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value), "SEMAPHORE");
        //    waitingthreads.Add((CreatedThreads.SelectedItem as string)!);
        //    Thread waitingThread = new Thread(() => { });

        //    foreach (var thread in Threads)
        //    {
        //        if (thread.ManagedThreadId == Convert.ToInt32((CreatedThreads.SelectedItem as string)!.Substring(6)))
        //        {
        //            waitingThread = thread;
        //        }
        //    }

        //    waitingThread.Start(semaphore);
        //    CreatedThreads.SelectedItem = null;
        //}
    }

}