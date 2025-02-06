
Implementación en ASP.NET 8.0 / MVC con C# usando Visual Studio 2022

Este proyecto incluye funcionalidades basadas en el rol del usuario:

Usuario Anónimo:

Registro como Cliente: El usuario se registra proporcionando todos sus datos. La contraseña debe ser alfanumérica y tener al menos 8 caracteres.
Login: El usuario ingresa su correo electrónico y contraseña para acceder según su rol.
Usuario Cliente:

Ver Publicaciones: El cliente puede ver todas las publicaciones con su nombre, estado, precio (para subastas, el valor de la oferta más alta), y comprar o ofertar en publicaciones abiertas.
Comprar en Venta: El cliente puede comprar si tiene suficiente saldo, lo que finaliza la publicación.
Ofertar en Subastas: El cliente puede ofertar un valor superior al más alto en subastas abiertas.
Cargar Saldo: El cliente puede agregar saldo a su billetera electrónica, siempre que el valor sea positivo.
Cerrar Sesión: El cliente puede cerrar sesión.
Usuario Administrador:

Ver Subastas: El administrador ve todas las subastas (abiertas y cerradas), ordenadas por fecha. Puede cerrar subastas abiertas.
Cerrar Subasta: El administrador cierra una subasta, adjudicando la publicación al mejor oferente.
Cerrar Sesión: El administrador puede cerrar sesión.

