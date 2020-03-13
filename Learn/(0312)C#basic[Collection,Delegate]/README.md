# My-Roadmap-as-Game-Developer
🗺️My Roadmap as Game-Developer
  
    

 
2020-03-12
=====


C#Basic
---

<hr>

collection
====

int[exp] new int[5] {1,2,3,4,5};
배열은 동적인 변화가 불가능함

컬렉션은 ArrayList, List, Queue, Stack, HashTable, Dictionary가 있음.

ArrayList
------
ArrayList arrayList = new ArrayList();
어레이리스트도 누군가 만들어놓은 클래스임. 이것은 using System.collections에서 가져온것임.
이 어레이 리스트에서는 add를 통해 추가할 수 있음.
arrayList.Add(1);
arrayList.Add("가나다라");
arrayList.Remove("가나다라");
arrayList.RemoveAt(3); //4번째를 지워라
arrayList.RemoveRange(1,2);//1를 포함해서 2개를 지우겠다. 즉 1번째 2번째를 지우겠다라는 말임.

arrayList[3] = 4; 이렇게 그냥 직접 접근해서 바꿔줄수도있음.

arrayList.Contains("가나다라");

arrayList.Insert(1,1.5);//이렇게하면 1과 가나다라 사이에 1.5라는 값이 들어감.



List
----
리스트는 특정한 형식만 받게해줌. <int>형식만 받게해줌.
List<int> list = new List<int>();이런식은 리스트

어레이리스트는 들어갈때하고 나갈때 연산을 요구함 그러니까 왠만하면 어레이리스트가 아닌 리스트를 사용해야함.


Hashtable
--------

Hashtable hashTable = new Hashtable();

hashTable.Add("만",10000);
hashTable.add("백",100);
print(hashTable["만"]); //이렇게 키값으로 찾아야함.

Dictionary
--------

Dictionary<string, int> dictionary = new Dictionary<string, int>();
//이렇게 명시하면
//dictionary.add(100,100);이런식으로 하면안됌
dictionary.add("백",100);이런식으로 해줘야함.
똑같이 헤시테이블은 성능상 불리하고 딕셔너리를 성능상 써줘야함. 왜냐하면 연산이 들어갈때하고 나갈때 또 해주기때문.


Queue 포션 제작 대기줄, 생산 대기명령.(스타크래프트)
-----
Queue는 자료형을 명시해도 되고 안해도됌
Queue queue = new Queue();
Queue<int> intQueue = new Queue<int>();

넣는것은
queue.Enqueue(5);
뺴는것은
queue.Dequeue();

Stack
-------
후입선출
스택도 자료형을 명시해도 되고 안해도됌
Stack<int> stack = new Stack<int>();

stack.push(1);
stack.push(2); 
stack.push(3);

print(stack.pop()); //3이 출력됌. 

<hr/>

Delegate
=====


int power;
int defence;
public void SetPower(int value)
{
	power += value;
	print("power's value is " + value + "added, result = " + power);	
}
public void SetDefence(int value)
{
	defence += value;
	print("defence's value is " + value + "added, result = " + defence);	
}
void start(){
setPower(5);
setDefence(5);
}


이런식으로 다 똑같은 것을 여러번 쓰면 복잡해진다.
그래서 
->

public delegate void ChainFunction(int value);
ChainFunction chain;

int power;
int defence;
public void SetPower(int value)
{
	power += value;
	print("power's value is " + value + "added, result = " + power);	
}
public void SetDefence(int value)
{
	defence += value;
	print("defence's value is " + value + "added, result = " + defence);	
}
void start(){
 chain += SetPower;
 chain += SetDefence;

//이렇게하면 함수하나에다가 전부 넣어놓을 수 있음. 예를 들어서 능력치를 조정하는 chain
chain(5);하면 power도 5가 올라가고 defence도 5가 올라감.
}

event
-----
타클래스의 함수까지 호출 가능하게 해줌.
static 선언이 일반적.

public delegate void ChainFunction(int value);
public static event ChainFunction Onstart; // 어떤 이벤트인데 체인펑션으로 만들어진 이벤트임
이런식으로 하면 다른 클래스에서도 해당 Onstart에 메소드를 집어넣을 수 있음.
이벤트로는 타클래스의 함수까지 관리감독할 수 있음.
}

<hr/>
