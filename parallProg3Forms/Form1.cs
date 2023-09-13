namespace parallProg3Forms
{
    public partial class Form1 : Form
    {
        static void RandFilVec(int[] vec, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                vec[i] = i;
                // 4-5
                // vec[i] = r.Next(0, 100);
            }
        }
        static void MultVec(int[] vec, int st, int en, int k)
        {
            for (int i = st; i < en; i++)
            {
                vec[i] *= k;
            }
        }
        public Form1()
        {
            InitializeComponent();
            // Создание столбцов с названиями
            DataGridViewTextBoxColumn columnNums1 = new DataGridViewTextBoxColumn();
            columnNums1.HeaderText = "Nums";
            dataGridView1.Columns.Add(columnNums1);

            DataGridViewTextBoxColumn columnThr1 = new DataGridViewTextBoxColumn();
            columnThr1.HeaderText = "Threads";
            dataGridView1.Columns.Add(columnThr1);

            DataGridViewTextBoxColumn columnSec1 = new DataGridViewTextBoxColumn();
            columnSec1.HeaderText = "Seconds";
            dataGridView1.Columns.Add(columnSec1);

            // Создание столбцов с названиями
            DataGridViewTextBoxColumn columnNums2 = new DataGridViewTextBoxColumn();
            columnNums2.HeaderText = "Nums";
            dataGridView2.Columns.Add(columnNums2);

            DataGridViewTextBoxColumn columnThr2 = new DataGridViewTextBoxColumn();
            columnThr2.HeaderText = "Threads";
            dataGridView2.Columns.Add(columnThr2);

            DataGridViewTextBoxColumn columnSec2 = new DataGridViewTextBoxColumn();
            columnSec2.HeaderText = "Seconds";
            dataGridView2.Columns.Add(columnSec2);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 10;
            if (radBut1.Checked)
            {
                n = 10;
            }
            else if (radBut2.Checked)
            {
                n = 100;
            }
            else if (radBut3.Checked)
            {
                n = 1000;
            }
            else if (radBut4.Checked)
            {
                n = 100000;
            }
            int[] m = { 2, 3, 4, 5, 10 };
            int c = 2;
            int[] vector = new int[n];
            RandFilVec(vector, n);
            int k = 3;
            // 4-5
            // Random rnd = new Random();
            // int k = rnd.Next(100, 10000);
            // Range
            for (int i = 0; i < 5; i++)
            {
                c = n / m[i];
                DateTime dt1, dt2;
                dt1 = DateTime.Now;
                Thread[] threads = new Thread[m[i]];
                for (int j = 0; j < m[i]; j++)
                {
                    int stInd = j * c;
                    int endInd = (j == m[i] - 1) ? n : (j + 1) * c;
                    threads[j] = new Thread(() =>
                    {
                        MultVec(vector, stInd, endInd, k);
                    }
                    );
                    threads[j].Start();
                }
                foreach (Thread thread in threads)
                {
                    thread.Join();
                }
                dt2 = DateTime.Now;
                TimeSpan ts = dt2 - dt1;
                string[] row1 = { Convert.ToString(n), Convert.ToString(m[i]), Convert.ToString(ts.TotalSeconds) };
                dataGridView1.Rows.Add(row1);
            }

            // Circle
            int[] vector2 = new int[n];
            RandFilVec(vector2, n);
            int k2 = 3;
            for (int v = 0; v < 5; v++)
            {
                int l = m[v];
                Task[] tasks = new Task[l];
                DateTime dt3, dt4;
                dt3 = DateTime.Now;
                // Круговое разделнеие с смещение threadIndex
                for (int threadIndex = 0; threadIndex < l; threadIndex++)
                {

                    int start = threadIndex;
                    tasks[threadIndex] = Task.Factory.StartNew(() =>
                    {
                        for (int i = start; i < vector2.Length; i += l)
                        {
                            vector2[i] = vector2[i] * k2;
                        }
                    });
                }
                Task.WaitAll(tasks);
                dt4 = DateTime.Now;
                TimeSpan ts2 = dt4 - dt3;
                string[] row2 = { Convert.ToString(n), Convert.ToString(l), Convert.ToString(ts2.TotalSeconds) };
                dataGridView2.Rows.Add(row2);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Удалить выбранную строку
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Проверяем, что строка не пуста
                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    // Проверка на новую строку
                    if (dataGridView1.Rows[rowIndex].IsNewRow)
                    {
                        MessageBox.Show("Это новая строка и ее удаление невозможно.", "Предупреждение");
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    // Вывод сообщения об ошибке или выполнение другой логики
                    MessageBox.Show("Выбранная строка не существует или пуста.", "Ошибка");
                    dataGridView1.ClearSelection();
                }
            }

            // Удалить выбранную строку
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;

                // Проверяем, что строка не пуста
                if (rowIndex >= 0 && rowIndex < dataGridView2.Rows.Count)
                {
                    // Проверка на новую строку
                    if (dataGridView2.Rows[rowIndex].IsNewRow)
                    {
                        MessageBox.Show("Это новая строка и ее удаление невозможно.", "Предупреждение");
                        dataGridView2.ClearSelection();
                    }
                    else
                    {
                        dataGridView2.Rows.RemoveAt(rowIndex);
                        dataGridView2.ClearSelection();
                    }
                }
                else
                {
                    // Вывод сообщения об ошибке или выполнение другой логики
                    MessageBox.Show("Выбранная строка не существует или пуста.", "Ошибка");
                    dataGridView2.ClearSelection();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Удалить все данные и снять выделение
            dataGridView1.Rows.Clear();
            dataGridView1.ClearSelection();
            dataGridView2.Rows.Clear();
            dataGridView2.ClearSelection();
        }
    }

}