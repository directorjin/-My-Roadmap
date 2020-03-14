# My-Roadmap-as-Game-Developer
🗺️My Roadmap as Game-Developer
  
    
 <hr>
 
2020-03-15
=====

T
--

형식매개변수 T는 어떤것이 올지 모를 때 임시로 지정해주게 한다.
그리고 해당 변수를 제한시켜둘 수 있음. 

void Print<T>(T value) where T : class //이렇게되면 string형식은 가능하지만 float형식은 불가능.
void Print<T>(T value) where T : struct //이렇게되면 float형식은 가능하지만 string형식은 불가능


클래스에서도 지정가능

public class Abc<T>//어떤 클래스를 생성하는데 이 클래스에서는 T라는 형식이 지정되지않은 변수를 쓸것이다.
{
	public T var;
	public T[] array;
}

Abc abcStack;//이건 스택영역에 올라감. 왜냐하면 동적으로 할당해주지 않았기 때문임.
Abc abcHeap = new Abc();//이건 힙영역에 올라감. 동적으로 할당해주었기 때문

abcStack.var = "abc"
abcHeap.var = "Abc"
이런식으로 사용가능.


Lamdba Expression
----------

myDelegate += Add;
myDelegate += () => print(sum);//람다식. ()이있다는 것은 어떤 함수인데 => 그것은 프린트 섬을 해주는 함수이다.라는 의미
myDelegate += Back;

myDelegate();



Action
----


이것은 사용해주기 위해 using System을 사용해야함. 
다만 이것은 void타입임. 델리게이트의 void타입과 같다고 보면 됌.

Func
---

이것은 사용해주기위해 using System을 사용해야함.
다만 이것은 인자가 다름
Func<int, int, string>으로 마지막 string이 반환형식임. 무조건 마지막 것은 반환형식임.



Coroutine
------

StopCorutine(myCoroutine1);//이말은 무슨말이나면 myCoroutine1에 대입되어있는 어떤 startCoroutine을 중지시키라는 말임.
오해하지말길
StopCorutine(LoopA())//이런식은 X 이런식으로 코루틴이 중지되지 않음.

문자열을 이용한 코루틴 시작은 쓰지말아야함. 왜냐하면 조금 더 과부화가 걸리기 때문.

Invoke
--
코루틴과 같지만 지연을 간단하게 구현해줌
InvokeRepeating("InvokeLog", 3f, 1f); //인보크 로그라는 것을 처음에 3초 지연시킨다음에 1초마다 실행시킨다.
Invoke("InvokeLog2", 10f);//처음 10초를 기다리고 실행시킨다.

CancelInvoke("InvokeLog")를 하면 인보크가 중지된다. 인보크는 ""타입의 String으로 제어


OverlapSphere
----------

Physhics.OverlapSphere(Vector3 원점, float 반경, LayerMask 마스크);
Collider[] cols = Physics.OverlapSphere(transform.position, 10.0f,player);
트랜스폼의 위치를 중심으로 10거리내읭 있는 오브젝트들의 콜라이더가 배열형태로 cols에 저장됌





