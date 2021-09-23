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

