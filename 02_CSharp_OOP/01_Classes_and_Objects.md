**클래스와 인스턴스 (Classes and Instances)**

**1. 핵심 개념**

*클래스(Class):* 객체를 만들기 위한 '설계도'. `Student`라는 개념을 `name`, `address` 같은 속성(데이터)과 특정 행위(메서드)로 묶은 것. 개발자가 만드는 새로운 '타입(Type)'이다.
*인스턴스(Instance) / 객체(Object):* `Student` 클래스라는 설계도를 바탕으로 메모리에 실체화된 '실제 학생'. `new Student()` 코드를 통해 생성된다.
*멤버(Member):* 클래스 내부에 정의된 모든 요소. 주로 필드(Field)와 메서드(Method)를 말한다.
*필드(Field):* 클래스에 소속된 변수. `name`, `address`처럼 객체의 상태(데이터)를 저장한다.
*`this` 키워드:* "나 자신의" 이라는 의미. 클래스 자신의 멤버(필드, 메서드)임을 명확히 할 때 사용한다.


**2. 내 생각 (왜 쓰는가?)**

* `학생 명부 양식`(클래스)과 `실제 학생 정보`(인스턴스)의 관계다. 잘 만든 양식 하나로 수많은 학생 정보를 체계적으로 관리하기 위해 사용한다.
* 관련 있는 데이터(`name`, `address`)와 기능(추후 추가될 `Study()`, `GoHome()` 등)을 `Student`라는 하나의 클래스로 묶음으로써, 코드를 논리적으로 관리하고 이해하기 쉽게 만든다(캡슐화).


**3. 코드 예시**
*   (Student 클래스를 정의하고, 인스턴스를 생성하여 사용하는 기본 예시)
    ```csharp
    // Student 라는 이름의 클래스(설계도) 정의
    public class Student
    {
        // 필드 (데이터). private으로 선언하여 외부에서 함부로 바꾸지 못하게 보호.
        private string name;
        private string address;

        // 생성자: 인스턴스가 생성될 때 호출됨 (자세한 내용은 02_Constructor.md 파일 참고)
        public Student(string name, string address)
        {
            // this.name은 이 클래스의 필드인 name을 가리킨다.
            this.name = name;
            this.address = address;
        }
        
        // 메서드 (기능)
        public void PrintInfo()
        {
            Console.WriteLine("이름: " + this.name + ", 주소: " + this.address);
        }
    }

    // Program.cs의 Main 메서드 안에서 사용
    // Student 클래스의 인스턴스(실제 학생) 2명 생성
    Student student1 = new Student("이창현", "서울");
    Student student2 = new Student("김철수", "부산");

    // 각 인스턴스의 메서드 호출
    student1.PrintInfo(); // "이름: 이창현, 주소: 서울" 출력
    student2.PrintInfo(); // "이름: 김철수, 주소: 부산" 출력
    ```


**4. 에러와 해결**

*에러:* `student1.name = "이영희";` 처럼 필드에 직접 접근하려고 하면 "보호 수준 때문에 접근할 수 없습니다" 라는 컴파일 에러 발생.
*해결:* `name` 필드가 `private`으로 선언되었기 때문. 클래스 외부에서는 직접 수정할 수 없다. 데이터를 수정하거나 조회하려면 `public`으로 공개된 메서드나 프로퍼티를 통해서만 가능하도록 설계해야 한다 (캡슐화).


**5. Q&A (멘토와의 대화)**
* (클래스의 일반적인 내용에 대한 질문을 여기에 기록한다.)