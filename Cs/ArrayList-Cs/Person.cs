public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        /// <summary>
        /// Override phương thức ToString để khi cần có thể in thông tin của object ra cho nhanh.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Name: " + name + " | Age: " + age;
        }
    }
