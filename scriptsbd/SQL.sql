-- --------------------------------------------------------
-- Anfitrião:                    devlab.thenotepad.eu
-- Versão do servidor:           Microsoft SQL Server 2019 (RTM-CU15) (KB5008996) - 15.0.4198.2
-- SO do servidor:               Linux (Ubuntu 20.04.3 LTS) <X64>
-- HeidiSQL Versão:              12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- A despejar estrutura da base de dados para PSI20L_AntonioMatos_2220077
DROP DATABASE IF EXISTS "PSI20L_AntonioMatos_2220077";
CREATE DATABASE IF NOT EXISTS "PSI20L_AntonioMatos_2220077";
USE "PSI20L_AntonioMatos_2220077";

-- A despejar estrutura para tabela PSI20L_AntonioMatos_2220077.Accounts
DROP TABLE IF EXISTS "Accounts";
CREATE TABLE IF NOT EXISTS "Accounts" (
	"ID" INT NOT NULL,
	"Account_Owner" INT NOT NULL,
	"IBan" VARCHAR(50) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Balance" INT NOT NULL DEFAULT '(0)',
	"AccountName" VARCHAR(30) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Accounts__Accoun__30F848ED" ("Account_Owner"),
	CONSTRAINT "FK__Accounts__Accoun__30F848ED" FOREIGN KEY ("Account_Owner") REFERENCES "Users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- A despejar dados para tabela PSI20L_AntonioMatos_2220077.Accounts: -1 rows
DELETE FROM "Accounts";
/*!40000 ALTER TABLE "Accounts" DISABLE KEYS */;
/*!40000 ALTER TABLE "Accounts" ENABLE KEYS */;

-- A despejar estrutura para tabela PSI20L_AntonioMatos_2220077.Cards
DROP TABLE IF EXISTS "Cards";
CREATE TABLE IF NOT EXISTS "Cards" (
	"ID" INT NOT NULL,
	"CardNumber" VARCHAR(16) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"CardExpireDate" DATE NOT NULL,
	"CardCVV" VARCHAR(4) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"AccountID" INT NOT NULL,
	"isActivated" BIT NOT NULL DEFAULT '(0)',
	"isFreeze" BIT NOT NULL DEFAULT '(0)',
	"isActivating" BIT NOT NULL DEFAULT '(0)',
	"ActivationCode" VARCHAR(8) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Cards__AccountID__34C8D9D1" ("AccountID"),
	CONSTRAINT "FK__Cards__AccountID__34C8D9D1" FOREIGN KEY ("AccountID") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- A despejar dados para tabela PSI20L_AntonioMatos_2220077.Cards: -1 rows
DELETE FROM "Cards";
/*!40000 ALTER TABLE "Cards" DISABLE KEYS */;
/*!40000 ALTER TABLE "Cards" ENABLE KEYS */;

-- A despejar estrutura para tabela PSI20L_AntonioMatos_2220077.Transactions
DROP TABLE IF EXISTS "Transactions";
CREATE TABLE IF NOT EXISTS "Transactions" (
	"ID" INT NOT NULL,
	"Sender_ID" INT NOT NULL,
	"Sender_Account" INT NOT NULL,
	"Receiver_ID" INT NOT NULL,
	"Receiver_Account" INT NOT NULL,
	"Quantity" INT NOT NULL,
	"Date" DATE NOT NULL DEFAULT 'getdate()',
	"Description" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Transacti__Sende__412EB0B6" ("Sender_Account"),
	FOREIGN KEY INDEX "FK__Transacti__Recei__4316F928" ("Receiver_Account"),
	FOREIGN KEY INDEX "FK__Transacti__Sende__403A8C7D" ("Sender_ID"),
	FOREIGN KEY INDEX "FK__Transacti__Recei__4222D4EF" ("Receiver_ID"),
	CONSTRAINT "FK__Transacti__Sende__412EB0B6" FOREIGN KEY ("Sender_Account") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Recei__4316F928" FOREIGN KEY ("Receiver_Account") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Sende__403A8C7D" FOREIGN KEY ("Sender_ID") REFERENCES "Users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Recei__4222D4EF" FOREIGN KEY ("Receiver_ID") REFERENCES "Users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- A despejar dados para tabela PSI20L_AntonioMatos_2220077.Transactions: -1 rows
DELETE FROM "Transactions";
/*!40000 ALTER TABLE "Transactions" DISABLE KEYS */;
/*!40000 ALTER TABLE "Transactions" ENABLE KEYS */;

-- A despejar estrutura para tabela PSI20L_AntonioMatos_2220077.Users
DROP TABLE IF EXISTS "Users";
CREATE TABLE IF NOT EXISTS "Users" (
	"ID" INT NOT NULL,
	"Username" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Password" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Email" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"MobilePhoneNumber" VARCHAR(18) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Birthday" DATE NOT NULL,
	"NIF" VARCHAR(9) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"CC" VARCHAR(20) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"VerifiedEmail" BIT NOT NULL DEFAULT '(0)',
	"VerifiedMobilePhone" BIT NOT NULL DEFAULT '(0)',
	"is2FAEnabled" BIT NULL DEFAULT '(0)',
	"LastIP" VARCHAR(15) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"isAdmin" BIT NOT NULL DEFAULT '(0)',
	PRIMARY KEY ("ID")
);

-- A despejar dados para tabela PSI20L_AntonioMatos_2220077.Users: -1 rows
DELETE FROM "Users";
/*!40000 ALTER TABLE "Users" DISABLE KEYS */;
INSERT INTO "Users" ("ID", "Username", "Password", "Email", "MobilePhoneNumber", "Birthday", "NIF", "CC", "VerifiedEmail", "VerifiedMobilePhone", "is2FAEnabled", "LastIP", "isAdmin") VALUES
	(3, 'Administrator', '87cc98676f7702ccf6d93e238979b068122d1b7bd751a2920050f1a7fc5fd13e', 'antonio.martim.matos@gmail.com', '929190105', '2022-05-10', '12345678', '23456789', b'1', b'1', b'0', '93.108.239.154', b'1');
/*!40000 ALTER TABLE "Users" ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
