namespace EIO.XF

open Xamarin.Forms
open Xamarin.Forms.Xaml

open Gjallarhorn.Bindable

open EIO

type MainPage() as this = 
    inherit Xamarin.Forms.ContentPage()    
    do
        this.LoadFromXaml(typeof<MainPage>) |> ignore