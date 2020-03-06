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
