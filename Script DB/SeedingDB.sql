USE P2P_LENDING_DB
GO
INSERT INTO Configuraciones VALUES (18, 2000, 200000, 6, 24, 0.2, 0.02, 0.2, '20201012')
INSERT INTO Configuraciones VALUES (21, 2000, 200000, 12, 24, 0.2, 0.02, 0.2, '20201013')
GO
INSERT INTO InteresPorCuotas VALUES (12, 0.15, 1)
INSERT INTO InteresPorCuotas VALUES (13, 0.16, 1)
INSERT INTO InteresPorCuotas VALUES (14, 0.17, 1)
INSERT INTO InteresPorCuotas VALUES (15, 0.18, 1)
INSERT INTO InteresPorCuotas VALUES (16, 0.19, 1)
INSERT INTO InteresPorCuotas VALUES (17, 0.20, 1)
INSERT INTO InteresPorCuotas VALUES (18, 0.21, 1)
INSERT INTO InteresPorCuotas VALUES (19, 0.22, 1)
INSERT INTO InteresPorCuotas VALUES (20, 0.23, 1)
INSERT INTO InteresPorCuotas VALUES (21, 0.24, 1)
INSERT INTO InteresPorCuotas VALUES (22, 0.25, 1)
INSERT INTO InteresPorCuotas VALUES (23, 0.26, 1)
INSERT INTO InteresPorCuotas VALUES (24, 0.27, 1)
GO
INSERT INTO InteresPorCuotas VALUES (6, 0.05, 2)
INSERT INTO InteresPorCuotas VALUES (7, 0.06, 2)
INSERT INTO InteresPorCuotas VALUES (8, 0.07, 2)
INSERT INTO InteresPorCuotas VALUES (9, 0.08, 2)
INSERT INTO InteresPorCuotas VALUES (10, 0.09, 2)
INSERT INTO InteresPorCuotas VALUES (11, 0.10, 2)
INSERT INTO InteresPorCuotas VALUES (12, 0.11, 2)
INSERT INTO InteresPorCuotas VALUES (13, 0.12, 2)
INSERT INTO InteresPorCuotas VALUES (14, 0.13, 2)
INSERT INTO InteresPorCuotas VALUES (15, 0.14, 2)
INSERT INTO InteresPorCuotas VALUES (16, 0.15, 2)
INSERT INTO InteresPorCuotas VALUES (17, 0.16, 2)
INSERT INTO InteresPorCuotas VALUES (18, 0.17, 2)
INSERT INTO InteresPorCuotas VALUES (19, 0.18, 2)
INSERT INTO InteresPorCuotas VALUES (20, 0.19, 2)
INSERT INTO InteresPorCuotas VALUES (21, 0.20, 2)
INSERT INTO InteresPorCuotas VALUES (22, 0.21, 2)
INSERT INTO InteresPorCuotas VALUES (23, 0.22, 2)
INSERT INTO InteresPorCuotas VALUES (24, 0.23, 2)
GO
INSERT INTO Usuario VALUES (11, '11', 'A', 'Manuel', 'De Armas', '19900215', 'manuel@gmail.com', 099879995)
INSERT INTO Usuario VALUES (22, '22', 'S', 'Pikachu', 'Lopez', '19950216', 'pikachu@gmail.com', 099879996)
INSERT INTO Usuario VALUES (42935326, 'Aa1234', 'S', 'Gordon', 'Gordoñez', '19910217', 'gordon@gmail.com', 099879997)
INSERT INTO Usuario VALUES (42935327, 'Aa1234', 'S', 'Sebastian', 'Sueldo', '20000218', 'sebastian@gmail.com', 099879998)
INSERT INTO Usuario VALUES (42935328, 'Aa1234', 'S', 'Diego', 'Cazes', '19970219', 'diego@gmail.com', 099879999)
GO
/*Pikachu Lopez*/
INSERT INTO Proyecto VALUES (	'P',
								'I',
								'Baubax Travel Jacket', 
								'TRAVEL JACKET with built-in Neck Pillow, Eye Mask, Gloves, Earphone Holders, Drink Pocket, Tech Pockets of all sizes! Comes in 4 Styles', 
								'baubaxTravelJacket.jpg',
								1,
								'bla bla bla',
								'20160615',
								22)
INSERT INTO Financiacion VALUES (10, 545, 5000, 0.09, 1, 2)
INSERT INTO Evaluacion VALUES ('F', NULL, NULL, 1, NULL)
INSERT INTO Proyecto VALUES (	'A',
								'C',
								'Coolest Cooler', 
								'The COOLEST is a portable party disguised as a cooler, bringing blended drinks, music and fun to any outdoor occasion. ', 
								'coolestCooler.jpg',
								3,
								NULL,
								'20180312',
								22)
INSERT INTO Financiacion VALUES (12, 1916.6667, 20000, 0.15, 2, 1)
INSERT INTO Evaluacion VALUES ('T', 8, '20180313', 2, 11)
INSERT INTO Proyecto VALUES (	'R',
								'C',
								'Critical Role: The Legend of Vox Machina Animated Special', 
								'Critical Role: The Legend of Vox Machina reunites your favorite heroes for a professional-quality animated special!', 
								'criticalRoleTheLegendOfVoxMachina.jpg',
								2,
								NULL,
								'20200611',
								22)
INSERT INTO Financiacion VALUES (10,1308, 12000, 0.09, 3, 2)
INSERT INTO Evaluacion VALUES ('T', 5, '20200620', 3, 11)
/*Gordon Gordoñez*/
INSERT INTO Proyecto VALUES (	'A',
								'I',
								'Exploding Kittens', 
								'This is a card game for people who are into kittens and explosions and laser beams and sometimes goats.', 
								'explodingKittens.png',
								1,
								'ble ble ble',
								'20200721',
								42935326)
INSERT INTO Financiacion VALUES (6,8750, 50000, 0.05, 4, 2)
INSERT INTO Evaluacion VALUES ('T', 9, '20200722', 4, 11)
/*Sebastian Sueldo*/
INSERT INTO Proyecto VALUES (	'P',
								'C',
								'Fidget Cube: A Vinyl Desk Toy', 
								'An unusually addicting, high-quality desk toy designed to help you focus. Fidget at work, in class, and at home in style.', 
								'fidgetCube.jpg',
								2,
								NULL,
								'20200407',
								42935327)
INSERT INTO Financiacion VALUES (18,8320, 128000,0.17, 5, 2)
INSERT INTO Evaluacion VALUES ('F', NULL, NULL, 4, NULL)
/*Diego Cazes*/
INSERT INTO Proyecto VALUES (	'R',
								'I',
								'Pebble Time - Awesome Smartwatch, No Compromises', 
								'Color e-paper smartwatch with up to 7 days of battery and a new timeline interface that highlights whats important in your day.', 
								'pebbleTimeSmartwatch.jpg',
								1,
								'blu blu blu',
								'20161207',
								42935328)
INSERT INTO Financiacion VALUES (24,7687.5, 150000,0.23, 6, 2)
INSERT INTO Evaluacion VALUES ('T', 4, '20161208', 6, 11)
