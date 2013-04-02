SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `repuestos` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `repuestos` ;


CREATE  TABLE IF NOT EXISTS `repuestos`.`clientes` (
  `idCliente` INT(11) NOT NULL AUTO_INCREMENT ,
  `Identificacion` VARCHAR(45) NOT NULL ,
  `Telefono` VARCHAR(45) NOT NULL ,
  `Celular` VARCHAR(45) NOT NULL ,
  `Direccion` VARCHAR(100) NOT NULL ,
  `TipoCliente` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idCliente`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`usuarios` (
  `idUsuario` INT(11) NOT NULL AUTO_INCREMENT ,
  `Usuario` VARCHAR(25) NOT NULL ,
  `Clave` VARCHAR(45) NOT NULL ,
  `FechaUltimoIngreso` DATETIME NOT NULL ,
  `Nombre` VARCHAR(45) NOT NULL ,
  `Apellido` VARCHAR(45) NOT NULL ,
  `Activo` INT(11) NOT NULL ,
  PRIMARY KEY (`idUsuario`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`facturas` (
  `idFactura` INT(11) NOT NULL AUTO_INCREMENT ,
  `Estado` VARCHAR(45) NOT NULL ,
  `Monto` DECIMAL(10,0) NOT NULL ,
  `Fecha` DATETIME NOT NULL ,
  `idCliente` INT(11) NOT NULL ,
  `idUsuarioFactura` INT(11) NOT NULL ,
  PRIMARY KEY (`idFactura`) ,
  INDEX `fk_facturas_clientes1_idx` (`idCliente` ASC) ,
  INDEX `fk_facturas_usuarios1_idx` (`idUsuarioFactura` ASC) ,
  CONSTRAINT `fk_facturas_clientes1`
    FOREIGN KEY (`idCliente` )
    REFERENCES `repuestos`.`clientes` (`idCliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_facturas_usuarios1`
    FOREIGN KEY (`idUsuarioFactura` )
    REFERENCES `repuestos`.`usuarios` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`tiporepuestos` (
  `idTipo` INT(11) NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idTipo`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`estilos` (
  `idEstilo` INT(11) NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idEstilo`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`combustibles` (
  `idCombustible` INT(11) NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idCombustible`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`marcas` (
  `idMarca` INT(11) NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  `PaisOrigen` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idMarca`) )
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`modelos` (
  `idModelo` INT NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  `idMarca` INT(11) NOT NULL ,
  PRIMARY KEY (`idModelo`) ,
  INDEX `fk_modelos_marcas1_idx` (`idMarca` ASC) ,
  CONSTRAINT `fk_modelos_marcas1`
    FOREIGN KEY (`idMarca` )
    REFERENCES `repuestos`.`marcas` (`idMarca` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`vehiculos` (
  `idVehiculo` INT(11) NOT NULL AUTO_INCREMENT ,
  `Ano` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  `idEstilo` INT(11) NOT NULL ,
  `idCombustible` INT(11) NOT NULL ,
  `idModelo` INT(11) NOT NULL ,
  `idMarca` INT(11) NOT NULL ,
  PRIMARY KEY (`idVehiculo`) ,
  INDEX `fk_vehiculos_estilos1_idx` (`idEstilo` ASC) ,
  INDEX `fk_vehiculos_combustibles1_idx` (`idCombustible` ASC) ,
  INDEX `fk_vehiculos_modelos1_idx` (`idModelo` ASC) ,
  INDEX `fk_vehiculos_marcas1_idx` (`idMarca` ASC) ,
  CONSTRAINT `fk_vehiculos_estilos1`
    FOREIGN KEY (`idEstilo` )
    REFERENCES `repuestos`.`estilos` (`idEstilo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculos_combustibles1`
    FOREIGN KEY (`idCombustible` )
    REFERENCES `repuestos`.`combustibles` (`idCombustible` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculos_modelos1`
    FOREIGN KEY (`idModelo` )
    REFERENCES `repuestos`.`modelos` (`idModelo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculos_marcas1`
    FOREIGN KEY (`idMarca` )
    REFERENCES `repuestos`.`marcas` (`idMarca` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`repuestos` (
  `idRepuesto` INT(11) NOT NULL AUTO_INCREMENT ,
  `NumeroParte` INT(11) NOT NULL ,
  `Inventario` INT(11) NOT NULL ,
  `Descripcion` VARCHAR(45) NOT NULL ,
  `PrecioUnitario` DECIMAL(10,0) NOT NULL ,
  `idTipo` INT(11) NOT NULL ,
  `idVehiculo` INT(11) NOT NULL ,
  PRIMARY KEY (`idRepuesto`) ,
  INDEX `fk_repuestos_tiporepuestos1_idx` (`idTipo` ASC) ,
  INDEX `fk_repuestos_vehiculos1_idx` (`idVehiculo` ASC) ,
  CONSTRAINT `fk_repuestos_tiporepuestos1`
    FOREIGN KEY (`idTipo` )
    REFERENCES `repuestos`.`tiporepuestos` (`idTipo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_repuestos_vehiculos1`
    FOREIGN KEY (`idVehiculo` )
    REFERENCES `repuestos`.`vehiculos` (`idVehiculo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE  TABLE IF NOT EXISTS `repuestos`.`facturaDetalles` (
  `idDetalle` INT(11) NOT NULL AUTO_INCREMENT ,
  `monto` DECIMAL(10,0) NOT NULL ,
  `cantidad` INT(11) NOT NULL ,
  `idFactura` INT(11) NOT NULL ,
  `idRepuesto` INT(11) NOT NULL ,
  PRIMARY KEY (`idDetalle`) ,
  INDEX `fk_facturaDetalles_facturas_idx` (`idFactura` ASC) ,
  INDEX `fk_facturaDetalles_repuestos1_idx` (`idRepuesto` ASC) ,
  CONSTRAINT `fk_facturaDetalles_facturas`
    FOREIGN KEY (`idFactura` )
    REFERENCES `repuestos`.`facturas` (`idFactura` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_facturaDetalles_repuestos1`
    FOREIGN KEY (`idRepuesto` )
    REFERENCES `repuestos`.`repuestos` (`idRepuesto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `repuestos` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
