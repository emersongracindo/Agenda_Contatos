-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema agenda_contatos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema agenda_contatos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `agenda_contatos` DEFAULT CHARACTER SET utf8 ;
USE `agenda_contatos` ;

-- -----------------------------------------------------
-- Table `agenda_contatos`.`Contatos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `agenda_contatos`.`Contatos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(40) NOT NULL,
  `email1` VARCHAR(40) NOT NULL,
  `email2` VARCHAR(40) NOT NULL,
  `fone1` VARCHAR(15) NOT NULL,
  `fone2` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;