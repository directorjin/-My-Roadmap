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
	
*important*	
<hr>

4. Indexer //특정값만 바꿔줄 수 있음 파라미터가 있음	
public string this[string key] //this가 인덱서의 핵심.		
{	
	get;	
	set;	
}	
	
	
5. Property //전체를 바꿔줌 파라미터가 없음. 쓰는 이유는 private로 은닉한 정보를 효과적으로 get하고 set 하기 위해	

public DataTime CacheExpires	
{	
	get {return cacheExpires;}	
	set {cacheExpires = value;}//여기서 value는 위에서 선언하지 않았아도 Property에서 자체적으로 구현되어있음.	
}	
private int salary;	
public int SalaryP	
{ 	
	get{ return salary;}	
	set{ salary = value;}//여기서 value는 위에서 선언하지 않았아도 Property에서 자체적으로 구현되어있음.	
	
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
변수의 관리는 프로퍼티로 관리하는 것이 좋음.	
<hr/>
