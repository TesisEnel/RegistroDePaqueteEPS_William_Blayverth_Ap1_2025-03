  **Cuentas**
**Admin**
  Usuario: buandblaivaeps@gmail.com
  Contraseña: Admin@123
**Cliente**
  Usuario: 064-000002
  Contraseña: Admin@123
  

# 📦 Registro de Paquetes EPS

## 📝 Descripción del Proyecto (Mini Manual)

Este proyecto es una aplicación web diseñada para la **gestión integral del flujo de paquetes** de una empresa de servicios de paquetería o *courier* (EPS). Permite a los usuarios y al personal administrativo registrar, rastrear y gestionar los paquetes desde el preaviso hasta la entrega final, incluyendo la gestión de cuentas de clientes, direcciones y personas autorizadas.

---

## 🛠️ Funcionalidades Principales

El sistema se centra en los siguientes módulos clave para el seguimiento y la administración de los envíos:

### 1. Pre-Avisos (Pre-Alertas)
* **Propósito:** Permite a los clientes notificar a la empresa sobre los paquetes que están en camino a la dirección del EPS antes de que lleguen.
* **Características:**
    * Creación de nuevos pre-avisos (`PreAvisoCreate.razor`).
    * Visualización y seguimiento de todos los pre-avisos registrados (`PreAvisoIndex.razor`).
    * Registro de información esencial como el número de rastreo (*tracking number*), proveedor, descripción y valor estimado.

### 2. Gestión de Paquetes
* **Propósito:** Permite al personal del EPS registrar y manejar los paquetes una vez que han sido recibidos en las instalaciones.
* **Características:**
    * Registro de nuevos paquetes entrantes (`PaqueteCreate.razor`).
    * Actualización del estado de los paquetes (e.g., Recibido en Miami, En Tránsito, Disponible para Retiro, Entregado). El historial de cambios de estado se registra a través de los modelos `EstatusPaquete` y `EstatusPaqueteDetalles`.
    * Visualización del listado completo de paquetes y sus estados actuales (`Paquete.razor`).

### 3. Módulo de Cuentas de Cliente
Este módulo permite a cada usuario gestionar la configuración de su cuenta personal.

#### a. Direcciones de Entrega (Delivery)
* **Propósito:** Permite al cliente registrar y administrar las diferentes direcciones a donde desea que sus paquetes sean enviados una vez lleguen al país.
* **Características:**
    * Registro y edición de múltiples direcciones de entrega (`DireccionUpsert.razor`).
    * Visualización de las direcciones registradas (`DireccionIndex.razor`).

#### b. Personas Autorizadas para Retiro
* **Propósito:** Permite a los clientes designar a otras personas que están autorizadas a retirar sus paquetes en su nombre en las oficinas.
* **Características:**
    * Registro de información de las personas autorizadas (nombre, identificación, etc.) (`AutorizacionUpsert.razor`).
    * Mantenimiento del listado de autorizados (`AutorizacionIndex.razor`).
