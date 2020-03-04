# My-Roadmap-as-Game-Developer
🗺️My Roadmap as Game-Developer
  
    
<hr>

ここは、私が勉強したことを整理しておく場所です。
====
  
  
<hr/>
      
2020-03-04
=====

<hr>
C#basic
----
IEnumerable, yield  
enum in the [Flags] 
bit operation, shift operation  
String(Substring(),Replace(),Remove(),Trim())  *string is immutable type*  so be careful of out of memory.  
StringBuilder(Append()) 
amespace  
struct  
the difference between struct(value) and class(reference). in the method. 
  
<hr/>
  
<hr>

UNITY Should Know 
----
UNITYを使う時に注意しなければならないこと。  
1.すべてをスクリプトで制御しようとするな。  
- 特定の地域をパトロールする船を作る際、スクリプトで制御するのではなくアニメーションで制御しなければならない。  
  
2.オーディオミキサーを利用しなさい。   
  
3.FindWithTagとFindメソッドを頻繁に利用するな。  
- TagとNameはいつでも変わるのでバグがよくできる。 そして最適化にも良くない。 
  
4.camera.mainをスクリプトで使用するな 。 
-MainCameraのTagを利用して検査するため、カメラを消して生成する過程でバグが生じる。  
  
5.、ユニティで提供されるProfilerを頻繁に確認しなさい。  
最適化のために必須だ。 
  
6.TextではなくTextMesh Proを利用しなさい。  
--UNITYで基本的に提供されるTextはよくない。 全部TextMesh Proに変えろ。  
  
7.少しでも重要なprivate変数なら[SerializeField]宣言をしなさい。  
-デバッグの時間を減らす。 
  
複雑なスクリプトなら[Header]を使ってグループを作れ。  
-デバッグの時間を減らす。 

<hr/>
