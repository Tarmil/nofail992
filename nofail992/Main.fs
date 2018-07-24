module nofail992
open WebSharper

type Chocolate =
  | [<Constant "Dark">] Dark
  | [<Constant "Cinnamon">] Cinnamon
  | [<Constant "Chilli">] Chilli

printfn "%A => %s" Cinnamon (Json.Serialize Cinnamon)
