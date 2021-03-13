Creatim Naloga (ASP.NET Core MVC)


Ključne datoteke: 

Controllers -> HomeController.cs

HomeController poleg default funkcij vsebuje tudi funkciji "NewProducts()" in "SimulateProducts()".
Obe kličejo ViewComponento, ki prilagodi izpis izdelkov glede na parametre. 
Obe funkciji sta del ajax klicev. 

ViewComponents -> NewProductsViewComponent.cs

Je class za našo View Componento. 
Ob izpisu View-a (katerega najdemo v Views > Shared > Components > NewProductsVC > Default.cshtml) podamo čez še dva parametra, ki se v View-ju imenujeta ViewBag.NumberOfProducts (število izdelkov) in ViewBag.Infinite (boolean, ki nam pove ali je infinite scroll vklopljen ali izklopljen).

Default.cshtml

Je HTML naše View Componente. Ubistvu je samo zanka, ki izpisuje izdelke. Ponovi pa se glede na ViewBag.NumberOfProducts.

Home -> Index.cshtml

Je popolnoma enak datoteki "Default.csthml". Razen, da ima na začetku določen filter, za prilagoditev izpisa števila izdelkov, ter da izpisuje natanko 8 izdelkov.


Views -> Shared -> _Layout.cshtml

Ta datoteka vsebuje:

 - Navigacijo z mega menijem
 - Carousel
 - footer
 - funkcije z AJAX klici 
 ("SimulateNewProducts()" -> ustvari infinite scroll efekt )
 ("SimulateProducts()" -> se uporabi s filtrom in z njo izbiramo med izpisom samo 4-ih izdelkov oz. 8-ih z infinite scrollom.)
   
