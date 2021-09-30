# cours_unity

## Vie et Mort 

pour détruire un composant OU un gameObject : 
```csharp
Destroy(gameObject);
// avec un delai de 3s :
Destroy(gameObject, 3f);
```

pour créer un gameObject à partir d'une source : 
- existant dans la scène : 
```csharp 
Instantiate(gameObject);
```

- en récupérant l'instance créee pour la détruire ensuite : 
```csharp
GameObject clone = Instantiate(gameObject);
Destroy(clone, 5f);
```

[voir usage dans CloneOnclick.cs](./Assets/CloneOnClick.cs)

## Compnent (acces a une instance, ajouter, détruire)

pour récupérer un compoant existant sur un gameObject,
on utilise `GetComponent<MonComposant>()`, par exemple :
```csharp
Rigidbody body = GetComponent<Rigidbody>();
```

Attention, le composant récupéré peut être nul (si il n'exite pas)
Voir usage dans [CubeController.cs](./Assets/scripts/tex.cs)

pour ajouter un composant sur un gameObject, 
on utilise `gameObject.AddComponent<MonComposant>()`, par exemple : 
```csharp
gameObject.AddComponent<Rigidbody>();
```

Voir usage dans [Eye.cs](./Assets/script/Eye.cs)

## Debug

pour mettre pause : 
```csharp
Debug.Break();
```