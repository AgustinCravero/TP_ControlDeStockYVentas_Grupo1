# TP_ControlDeStockYVentas_Grupo1
Descripción del sistema: El sistema a desarrollar está orientado a pequeños comercios que necesitan controlar de manera simple su inventario y las ventas realizadas. Permitirá registrar productos, actualizar su stock automáticamente al efectuarse una venta y generar reportes básicos que ayuden a analizar el desempeño del negocio.
Las Principales entidades del sistema serán: Producto, Venta, Proveedor. 

Objetivos y funcionalidades previstas: 
Gestionar productos (alta, baja y modificación).
Gestionar proveedores (alta, baja y modificación). 
Registrar ventas, descontando automáticamente el stock de los productos vendidos. 
Consultar el estado actual del inventario.
Generar reportes sobre las ventas y el stock.

Objetivos/Funcionalidades específicas: 
Alta de producto: permitir registrar un nuevo producto indicando nombre, descripción, precio y cantidad inicial de stock.
Baja de producto: eliminar del sistema productos que ya no se comercializan.
Modificación de producto: actualizar información de un producto existente (precio, descripción o stock).
Registrar y mantener información de proveedores. 
Registro de venta: generar una venta seleccionando productos, cantidades y calculando el total, actualizando automáticamente el stock. 

Reportes: 
Reporte de ventas por período: mostrar el total de ventas realizadas dentro de un rango de fechas. 
Reporte de stock bajo: listar los productos cuyo stock actual se encuentra por debajo de un nivel mínimo definido, permitiendo anticipar la reposición.

Integración de capas para guardar un registro en la base de datos: 
En el sistema, cuando el usuario desea crear, modificar o eliminar un registro, se hace a través del Front, donde se ingresan o actualizan los datos y se ejecuta una acción correspondiente. Al realizar esta acción, el programa crea o actualiza un objeto del tipo definido en la carpeta Models, la cual contiene las clases que representan las entidades del sistema.
Luego, se llama a un método del repositorio, ubicado en la carpeta Repositories, que se encarga de ejecutar la operación sobre la base de datos. Este repositorio utiliza la clase ApplicationDbContext, que mantiene la conexión con la base de datos usando EF y administra los DbSet asociados a las tablas. Al ejecutar el método SaveChanges(), se reflejan los cambios en la base de datos.
