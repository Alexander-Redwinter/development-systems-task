Разработать проект и выложить его на github.

Проект при компиляции должен формировать файл-библиотеку с именем lib.dll Namespace по умолчанию ds.test.impl 

При подключении данной библиотеки в данном Namespace должны быть доступны 1 интерфейс IPlugin и один статический класс Plugins: 
```
 public interface IPlugin 
 { 
 string PluginName { get; } 
 string Version { get; }  
 System.Drawing.Image Image { get; } 
 string Description { get; } 
 int Run (int input1, int input2);  
 } 
 ```
Статический класс Plugins должен реализовывать интерфейс: 
```
 interface PluginFactory 
 { 
 int PluginsCount { get; } 
 string[] GetPluginNames { get; }  
 IPlugin GetPlugin (string pluginName);  
 } 
 ```
Часть реализаций интерфейса IPlugin должна быть унаследована от закрытого абстрактного класса

Метод Run должен реализовывать различные математические функции (сложение умножение и  т.п. их количество зависит от Вашего желания помочь экипажу)

Библиотека должна работать стабильно, должны быть реализованы все необходимые проверки,  должно использоваться документирование, так чтобы у экипажа не возникло вопросов как  пользоваться данной библиотекой.

В реализации интерфейсов допускается, но не рекомендуется использование сторонних  