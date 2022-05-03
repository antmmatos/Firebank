DROP DATABASE IF EXISTS "PSI20L_AntonioMatos_2220077";
CREATE DATABASE IF NOT EXISTS "PSI20L_AntonioMatos_2220077";
USE "PSI20L_AntonioMatos_2220077";

DROP TABLE IF EXISTS "Accounts";
CREATE TABLE IF NOT EXISTS "Accounts" (
	"ID" INT NOT NULL,
	"Account_Owner" INT NOT NULL,
	"IBan" VARCHAR(50) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Balance" INT NOT NULL DEFAULT '(0)',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Accounts__Accoun__30F848ED" ("Account_Owner"),
	CONSTRAINT "FK__Accounts__Accoun__30F848ED" FOREIGN KEY ("Account_Owner") REFERENCES "users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

DROP TABLE IF EXISTS "Billing";
CREATE TABLE IF NOT EXISTS "Billing" (
	"ID" INT NOT NULL,
	"User_ID" INT NOT NULL,
	"Quantidade" DECIMAL(18,0) NOT NULL,
	"Descricao" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Billing__User_ID__2D27B809" ("User_ID"),
	CONSTRAINT "FK__Billing__User_ID__2D27B809" FOREIGN KEY ("User_ID") REFERENCES "users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

DROP TABLE IF EXISTS "Cards";
CREATE TABLE IF NOT EXISTS "Cards" (
	"ID" INT NOT NULL,
	"CardNumber" VARCHAR(16) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"CardExpireDate" DATE NOT NULL,
	"CardCVV" VARCHAR(4) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"AccountID" INT NOT NULL,
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Cards__AccountID__34C8D9D1" ("AccountID"),
	CONSTRAINT "FK__Cards__AccountID__34C8D9D1" FOREIGN KEY ("AccountID") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

DROP TABLE IF EXISTS "Transactions";
CREATE TABLE IF NOT EXISTS "Transactions" (
	"ID" INT NOT NULL,
	"Sender_ID" INT NOT NULL,
	"Sender_Account" INT NOT NULL,
	"Receiver_ID" INT NOT NULL,
	"Receiver_Account" INT NOT NULL,
	"Quantity" INT NOT NULL,
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__Transacti__Sende__403A8C7D" ("Sender_ID"),
	FOREIGN KEY INDEX "FK__Transacti__Sende__412EB0B6" ("Sender_Account"),
	FOREIGN KEY INDEX "FK__Transacti__Recei__4222D4EF" ("Receiver_ID"),
	FOREIGN KEY INDEX "FK__Transacti__Recei__4316F928" ("Receiver_Account"),
	CONSTRAINT "FK__Transacti__Sende__403A8C7D" FOREIGN KEY ("Sender_ID") REFERENCES "users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Recei__4222D4EF" FOREIGN KEY ("Receiver_ID") REFERENCES "users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Sende__412EB0B6" FOREIGN KEY ("Sender_Account") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Transacti__Recei__4316F928" FOREIGN KEY ("Receiver_Account") REFERENCES "Accounts" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

DROP TABLE IF EXISTS "users";
CREATE TABLE IF NOT EXISTS "users" (
	"ID" INT NOT NULL,
	"Username" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Password" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Email" VARCHAR(100) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"MobilePhoneNumber" VARCHAR(18) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"Birthday" DATE NOT NULL,
	"NIF" VARCHAR(9) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"CC" VARCHAR(20) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"VerifiedEmail" BIT NOT NULL DEFAULT '(0)',
	"VerfiedMobilePhone" BIT NOT NULL DEFAULT '(0)',
	"TwoFactorToken" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"LastIP" VARCHAR(15) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID")
);

DROP TABLE IF EXISTS "User_Settings";
CREATE TABLE IF NOT EXISTS "User_Settings" (
	"ID" INT NOT NULL,
	"Settings_UserID" INT NOT NULL,
	"SettingName" VARCHAR(50) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"SettingValue" VARCHAR(10) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("ID"),
	FOREIGN KEY INDEX "FK__User_Sett__Setti__29572725" ("Settings_UserID"),
	CONSTRAINT "FK__User_Sett__Setti__29572725" FOREIGN KEY ("Settings_UserID") REFERENCES "users" ("ID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);