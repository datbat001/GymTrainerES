USE [GymTrainer]
GO
/*Peso Ideal*/
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Espalda Superior', 'Remo con Cable Sentado', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Pecho', 'Pecho en Banco Plano', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Hombros', 'Hombro con Mancuernas', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Trapecios', 'Encogimiento con Mancuerna', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Triceps', 'Triceps con Cable(Pushdown)', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Biceps', 'Biceps con Barra', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Espalda Baja', 'Extensiones de Espalda', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Pantorrillas', 'Pantorrillas Parado', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Ante Brazo', 'Encogimiento de muñeca con Barra', 3, 5);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Peso Ideal', 'Abdominales', 'Encogimientos', 3, 5);

/*Sobre Peso*/
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Quadriceps/Gluteos', 'Leg Press(Prensa)', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Biceps Femoral', 'Maquina de Biceps Femoral', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Espalda Superior', 'Remo con Cable Sentado', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Pecho', 'Pecho en Banco Plano', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Hombros', 'Hombro con Mancuernas', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Trapecios', 'Encogimiento con Mancuerna', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Triceps', 'Triceps con Cable(Pushdown)', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Biceps', 'Biceps con Barra', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Espalda Baja', 'Extensiones de Espalda', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Pantorrillas', 'Pantorrillas Parado', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Ante Brazo', 'Encogimiento de muñeca con Barra', 4, 7);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sobre Peso', 'Abdominales', 'Encogimientos', 4, 7);

/*Sacar Musculo*/
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sacar Musculo', 'Pecho y Triceps', 'Pecho en Banco Plano & Triceps con cable (Pushdown)', 8, 15);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sacar Musculo', 'Espalda y Biceps', 'Remo con Cable Sentado & Extensiones de Espalda & Maquina de Biceps Femoral & Biceps con Bara', 8, 15);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sacar Musculo', 'Antebrazos y Hombros', 'Encogimiento de muñeca con Barra & Hombro con Mancuernas', 8, 15);
insert into [dbo].[ejercicios] ([Tipo], [Body_Part], [Ejercicio], [Serie], [Repeticion]) values ('Sacar Musculo', 'Piernas', 'Leg Press (Prensa)', 8, 15);

GO


UPDATE [dbo].[ejercicios]
   SET [Tipo] = 'Tonificar'
 WHERE [Tipo] = 'Sacar Musculo'
GO


