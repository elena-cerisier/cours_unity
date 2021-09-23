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