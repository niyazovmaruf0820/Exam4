// Generics - baroi yak fuctiona dar chand type istifoda burdan meboshad.


void GetElements<T>(List<T> values)
{
    foreach (var item in values)
    {
        System.Console.Write(item + " ");
    }
}

List<int> ints = new List<int>(){1, 2, 3, 4, 5};
GetElements(ints);
System.Console.WriteLine();
List<string> strings = new List<string>(){"apple","pear", "pineapple","watermelon"};
GetElements(strings);

// Dar in misol mo mebinem ki methodi {GetElements} dar chand type ba kor rafta istodaaast.
// Boz mo metavonem classhoro ham generic kunem.
// Baroi misol mo yak classe dorem ki qarib hamai typosh yakkhela hast mo metavonem classro generic kunem to ki baroi dar chand type istifoda burdan

// Обобщенные классы позволяют нам написать одну реализацию, которая может быть использована с разными типами данных.
