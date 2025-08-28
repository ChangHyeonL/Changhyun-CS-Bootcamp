### 1. 변수 (Variable)

**핵심 개념:** 데이터를 저장하기 위해 이름 붙인 메모리 공간.

**내 생각(왜 쓰는가?):** 이거 없으면 숫자 10이 필요할 때마다 계속 10을 쳐야 함. 재사용과 관리가 불가능. 이름(label)을 붙여서 편하게 쓰려고.

**코드 예시:**
```csharp
// 변수 선언 및 초기화
int level = 10;
float attackDamage = 35.5f;
string playerName = "창현";

// 변수 사용
Console.WriteLine(playerName + "의 레벨은 " + level + "입니다.");