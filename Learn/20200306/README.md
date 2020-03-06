# My-Roadmap-as-Game-Developer
🗺️My Roadmap as Game-Developer
  
    
 <hr>
 
2020-03-06
=====

C#basic
----
	
1. internal class //내부적인 빌드안에서만 작동하는 클래스	
2. public class //외부에서 빌드해서 dll 생성후 솔루션 익스플로러에서 가져오기를 통해서 해당 클래스를 사용할 수 있게됌	
3. Dictionary //	
Dictionary<string,string> cache; //key도 value도 string타입임.	
	
	
<hr>
*important*
----------


4. Indexer //특정값만 바꿔줄 수 있음 파라미터가 있음	  

public string this[string key] //this가 인덱서의 핵심.	  
{	  
	get;		  
	set;		  
}	  
	  
	  
5. Property //전체를 바꿔줌 파라미터가 없음. 쓰는 이유는 private로 은닉한 정보를 get하고 set을 설정해서 코드의 가독성을 높이기 위해  
  
public DataTime CacheExpires	  
{	  
	get {return cacheExpires;}  	
	set {cacheExpires = value;}//여기서 value는 위에서 선언하지 않았아도 Property에서 자체적으로 구현되어있음.  
private int salary;	  
public int SalaryP  	
{ 	  
	get{ return salary;}	  
	private set {salary = value;}//private로 설정해준 이유는 set. 즉 SalaryP = 2;와 같이 Start에서 실행해주는 것은 괜찮지만 은닉성 보장을 위해 다른 클래스에서의 접근은 막아야 하기 때문임. 
	  
private int salary;	  
//쓰는 이유? 	  
public int GetSalary()	  
{	  
	return salary;	  
}	  
public void SetSalary(int value)  
{	  
	salary = value;	  
}	  
//이런식으로 구현할 수도 있지만 이렇게 되면 함수자체가 무지막지하게 많아짐. 가독성이 떨어지기 때문에 private로 선언된  	
변수의 관리는 프로퍼티로 관리하는 것이 좋음. 그리고 get을 할때 어떤 private 변수를 건드리지않고 조작할 수 있고(salary + bonus), set을 할때는 if 조건문을 이용해서 if(value <0) {print("error");} else {salary = value;} 이런식으로도 설정가능함.	  

visual studio환경에서 🔧는 전부 property임. array의 lenth가 프로퍼티로 구현되어있음.
<hr/>  

1. [SerializeField]

<img src="https://user-images.githubusercontent.com/44941601/76096471-832da400-6009-11ea-8192-6c1f7e7910a4.png">


 - private 변수를 인스펙터에 노출시킴

 - [System.Serializable]을 사용한 Structure 타입 변수에 사용하면 인스펙터에 노출되는 효과.





2. [HideInInspector]







 - 이건 반대로 public 이라도 인스펙터에 노출시키지 않음





3. [Range(최소값,최대값)]









 - 인스펙터에서 입력할 때 변수의 수치를 제한해서 입력할 수 있다.

 - 실제 값을 제한시키는 효과는 없어서 넘는 수치를 대입하면 그대로 들어간다.





4. [Header("라벨명"]









 - 변수 앞에 라벨을 표기한다.

 - 보통 구분이 잘 안되서 -나 * 같은 특수문자를 넣어서 표시한다. 




5. [Space] , [Space(int height)]









 - 변수 사이에 한줄을 띄워준다 라벨을 굳이 달지 않더라도 정리하고 싶을때 사용한다.

 - 뒤에 매개변수로 높이를 넣어줄 수 있다.





6. [TextArea] , [Multiline] , [TextArea(int line)] , [Multiline(int line)]









 - string 타입의 변수를 여러줄로 입력할 수 있다.

 - 변수명 라벨과 다른줄로 표기되느냐 한 줄로 표기되는냐 차이

 - 이 attribute를 사용하면 string 타입에서 엔터를 따로 처리안해줘도 된다!

 - 역시 뒤쪽에 int값으로 줄 갯수를 넣어줄 수 있다. 디폴트는 3





7. [ColorUsage(bool alphaView)]









 - 컬러픽커를 사용한다. 뒤의 bool 값은 알파값도 포함하는지여부
