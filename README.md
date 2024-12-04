Implementación en ASP.NET 8.0 / MVC con C#, utilizando Visual Studio 2022, de los siguientes ítems
dependiendo del rol del usuario:

Usuario Anónimo:
3. Registrarse como cliente. Se le solicitarán todos los datos y quedará registrado en el sistema. La
contraseña deberá ser alfanumérica y tendrá un largo mínimo de 8 dígitos.
4. Login. Ingresará email y contraseña y en caso de que sean válidos quedará autorizado a acceder a las
funcionalidades correspondientes a su rol.

Usuario Cliente:
5. Ver todas las publicaciones: El cliente podrá ver todas las publicaciones en cualquier estado mostrando
para cada una su nombre, estado, precio (para las subastas será el valor de la oferta más alta), y para
cada una de las que estén en estado “Abierta” podrá comprar o realizar una oferta, dependiendo del tipo
de publicación. (Ver puntos 6 y 7). El precio de cada publicación debe calcularse en función de lo
indicado en la letra del primer obligatorio.
6. Comprar una publicación de tipo venta: El cliente podrá realizar una compra de una publicación si
cuenta con dinero para hacerlo. Esta acción dispara la lógica de finalización de una publicación.
7. Ofertar en una subasta: El cliente podrá ofertar en una subasta, un valor superior al valor más alto hasta
el momento.
8. Cargar saldo en su billetera electrónica: El cliente podrá cargar saldo en su billetera electrónica, el
valor no debe ser negativo
9. Logout: Cierra sesión

Usuario Administrador:
10. Ver todas las subastas: El Administrador verá la lista de subastas tanto abiertas como cerradas,
ordenadas por fecha de publicación, y para las que estén en estado “abierta” tendrá la posibilidad de
cerrarlas. De cada una se mostrará el nombre, el tipo, la fecha de publicación, el estado, y el precio. Para
las subastas el precio mostrado es el de la mejor oferta realizada hasta el momento.
11. Cerrar una subasta: Cerrará una subasta, adjudicándosela al mejor oferente, y disparando la lógica de
finalización de publicación.
12. Logout: Cierra sesión 