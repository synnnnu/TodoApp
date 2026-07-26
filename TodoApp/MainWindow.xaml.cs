using System.Collections.ObjectModel;  // ObservableCollection을 쓰기 위해 필요
using System.Windows;


namespace TodoApp
{
    public partial class MainWindow : Window
    {
        // ObservableCollection: 일반 List와 달리, 항목이 추가/삭제되면
        // 화면(ListBox)에 자동으로 반영해주는 특별한 컬렉션.
        // 자바의 ArrayList에 리스너를 미리 붙여둔 버전이라고 생각하면 됨
        public ObservableCollection<string> Tasks { get; set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            // ListBox의 ItemsSource(데이터 원본)로 Tasks를 지정.
            // 이제 Tasks에 항목을 추가/삭제하면 ListBox 화면이 자동으로 갱신됨
            TaskListBox.ItemsSource = Tasks;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // 입력창이 비어있지 않을 때만 추가
            if (!string.IsNullOrWhiteSpace(TaskInput.Text))
            {
                Tasks.Add(TaskInput.Text);  // 목록에 추가 -> 화면 자동 갱신
                TaskInput.Clear();          // 입력창 비우기
            }
        }
    }
}