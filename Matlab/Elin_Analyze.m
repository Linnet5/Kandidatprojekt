

%%
% För att titta på datan som sparas i mobilen

clear;
clc;
%45grader

[Epar1_1, EaccelX_1, Ekoma1_1, EaccelY_1, Ekoma2_1, EaccelZ_1, Epar2_1] = textread('Testfram-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Epar1_2, EaccelX_2, Ekoma1_2, EaccelY_2, Ekoma2_2, EaccelZ_2, Epar2_2] = textread('Fyrtiofemgrader-20meanGyroList-0.txt', '%c %f %c %f %c %f %c');
%[Epar1_3, EaccelX_3, Ekoma1_3, EaccelY_3, Ekoma2_3, EaccelZ_3, Epar2_3] = textread('Testdoor-20meanGyroList-0.txt', '%c %f %c %f %c %f %c');
%[Epar1_4, EaccelX_4, Ekoma1_4, EaccelY_4, Ekoma2_4, EaccelZ_4, Epar2_4] = textread('Testwall-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');


t = 1:1:length(EaccelZ_1);

figure(1);
title('X-axel. Horizontell/45�')
hold on;
plot(t,EaccelX_1);
plot(t,EaccelX_2);
legend('Horisontell','45�')
hold off;

figure(2);
title('Y-axel. Horizontell/45�')
hold on;
plot(t,EaccelY_1);
plot(t,EaccelY_2);
legend('Horisontell','45�')
hold off;


figure(3);
title('Z-axel. Horizontell/45�')
hold on;
plot(t,EaccelZ_1);
plot(t,EaccelZ_2);
legend('Horisontell','45�')
hold off;
%% Olika riktningar
clear;
clc;

[Epar1_1, EaccelX_1, Ekoma1_1, EaccelY_1, Ekoma2_1, EaccelZ_1, Epar2_1] = textread('Testfram-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Epar1_2, EaccelX_2, Ekoma1_2, EaccelY_2, Ekoma2_2, EaccelZ_2, Epar2_2] = textread('Testwindow-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Epar1_3, EaccelX_3, Ekoma1_3, EaccelY_3, Ekoma2_3, EaccelZ_3, Epar2_3] = textread('Testdoor-20meanGyroList-0.txt', '%c %f %c %f %c %f %c');
[Epar1_4, EaccelX_4, Ekoma1_4, EaccelY_4, Ekoma2_4, EaccelZ_4, Epar2_4] = textread('Testwall-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');


t = 1:1:length(EaccelZ_4);

figure(1);
title('X-axel. Gyro-Medelv�rde')
hold on;
plot(t,EaccelX_1);
plot(t,EaccelX_2);
plot(t,EaccelX_3);
plot(t,EaccelX_4);
legend('Fram�t','H�ger','Back�t', 'V�nster')
hold off;

figure(2);
title('Y-axel. Gyro-Medelv�rde')
hold on;
plot(t,EaccelY_1);
plot(t,EaccelY_2);
plot(t,EaccelY_3);
plot(t,EaccelY_4);
legend('Fram�t','H�ger','Back�t', 'V�nster')
hold off;


figure(3);
title('Z-axel. Gyro-Medelv�rde')
hold on;
plot(t,EaccelZ_1);
plot(t,EaccelZ_2);
plot(t,EaccelZ_3);
plot(t,EaccelZ_4);
legend('Fram�t','H�ger','Back�t', 'V�nster')
hold off;
%% Medel av alla accel
clear;
clc;
figure;

[Epar1_1, EaccelX_1, Ekoma1_1, EaccelY_1, Ekoma2_1, EaccelZ_1, Epar2_1] = textread('Elin-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Epar1_2, EaccelX_2, Ekoma1_2, EaccelY_2, Ekoma2_2, EaccelZ_2, Epar2_2] = textread('Elin-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Epar1_3, EaccelX_3, Ekoma1_3, EaccelY_3, Ekoma2_3, EaccelZ_3, Epar2_3] = textread('Elin-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Epar1_4, EaccelX_4, Ekoma1_4, EaccelY_4, Ekoma2_4, EaccelZ_4, Epar2_4] = textread('Elin-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Epar1_5, EaccelX_5, Ekoma1_5, EaccelY_5, Ekoma2_5, EaccelZ_5, Epar2_5] = textread('Elin-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Epar1_6, EaccelX_6, Ekoma1_6, EaccelY_6, Ekoma2_6, EaccelZ_6, Epar2_6] = textread('Elin-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Epar1_7, EaccelX_7, Ekoma1_7, EaccelY_7, Ekoma2_7, EaccelZ_7, Epar2_7] = textread('Elin-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Epar1_8, EaccelX_8, Ekoma1_8, EaccelY_8, Ekoma2_8, EaccelZ_8, Epar2_8] = textread('Elin-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Epar1_9, EaccelX_9, Ekoma1_9, EaccelY_9, Ekoma2_9, EaccelZ_9, Epar2_9] = textread('Elin-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Epar1_10, EaccelX_10, Ekoma1_10, EaccelY_10, Ekoma2_10, EaccelZ_10, Epar2_10] = textread('Elin-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');


[Lpar1_1, LaccelX_1, Lkoma1_1, LaccelY_1, Lkoma2_1, LaccelZ_1, Lpar2_1] = textread('Linus-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Lpar1_2, LaccelX_2, Lkoma1_2, LaccelY_2, Lkoma2_2, LaccelZ_2, Lpar2_2] = textread('Linus-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Lpar1_3, LaccelX_3, Lkoma1_3, LaccelY_3, Lkoma2_3, LaccelZ_3, Lpar2_3] = textread('Linus-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Lpar1_4, LaccelX_4, Lkoma1_4, LaccelY_4, Lkoma2_4, LaccelZ_4, Lpar2_4] = textread('Linus-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Lpar1_5, LaccelX_5, Lkoma1_5, LaccelY_5, Lkoma2_5, LaccelZ_5, Lpar2_5] = textread('Linus-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Lpar1_6, LaccelX_6, Lkoma1_6, LaccelY_6, Lkoma2_6, LaccelZ_6, Lpar2_6] = textread('Linus-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Lpar1_7, LaccelX_7, Lkoma1_7, LaccelY_7, Lkoma2_7, LaccelZ_7, Lpar2_7] = textread('Linus-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Lpar1_8, LaccelX_8, Lkoma1_8, LaccelY_8, Lkoma2_8, LaccelZ_8, Lpar2_8] = textread('Linus-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Lpar1_9, LaccelX_9, Lkoma1_9, LaccelY_9, Lkoma2_9, LaccelZ_9, Lpar2_9] = textread('Linus-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Lpar1_10, LaccelX_10, Lkoma1_10, LaccelY_10, Lkoma2_10, LaccelZ_10, Lpar2_10] = textread('Linus-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');


[Mpar1_1, MaccelX_1, Mkoma1_1, MaccelY_1, Mkoma2_1, MaccelZ_1, Mpar2_1] = textread('Max-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Mpar1_2, MaccelX_2, Mkoma1_2, MaccelY_2, Mkoma2_2, MaccelZ_2, Mpar2_2] = textread('Max-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Mpar1_3, MaccelX_3, Mkoma1_3, MaccelY_3, Mkoma2_3, MaccelZ_3, Mpar2_3] = textread('Max-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Mpar1_4, MaccelX_4, Mkoma1_4, MaccelY_4, Mkoma2_4, MaccelZ_4, Mpar2_4] = textread('Max-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Mpar1_5, MaccelX_5, Mkoma1_5, MaccelY_5, Mkoma2_5, MaccelZ_5, Mpar2_5] = textread('Max-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Mpar1_6, MaccelX_6, Mkoma1_6, MaccelY_6, Mkoma2_6, MaccelZ_6, Mpar2_6] = textread('Max-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Mpar1_7, MaccelX_7, Mkoma1_7, MaccelY_7, Mkoma2_7, MaccelZ_7, Mpar2_7] = textread('Max-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Mpar1_8, MaccelX_8, Mkoma1_8, MaccelY_8, Mkoma2_8, MaccelZ_8, Mpar2_8] = textread('Max-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Mpar1_9, MaccelX_9, Mkoma1_9, MaccelY_9, Mkoma2_9, MaccelZ_9, Mpar2_9] = textread('Max-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Mpar1_10, MaccelX_10, Mkoma1_10, MaccelY_10, Mkoma2_10, MaccelZ_10, Mpar2_10] = textread('Max-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');

[Rpar1_1, RaccelX_1, Rkoma1_1, RaccelY_1, Rkoma2_1, RaccelZ_1, Rpar2_1] = textread('Ruben-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Rpar1_2, RaccelX_2, Rkoma1_2, RaccelY_2, Rkoma2_2, RaccelZ_2, Rpar2_2] = textread('Ruben-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Rpar1_3, RaccelX_3, Rkoma1_3, RaccelY_3, Rkoma2_3, RaccelZ_3, Rpar2_3] = textread('Ruben-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Rpar1_4, RaccelX_4, Rkoma1_4, RaccelY_4, Rkoma2_4, RaccelZ_4, Rpar2_4] = textread('Ruben-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Rpar1_5, RaccelX_5, Rkoma1_5, RaccelY_5, Rkoma2_5, RaccelZ_5, Rpar2_5] = textread('Ruben-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Rpar1_6, RaccelX_6, Rkoma1_6, RaccelY_6, Rkoma2_6, RaccelZ_6, Rpar2_6] = textread('Ruben-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Rpar1_7, RaccelX_7, Rkoma1_7, RaccelY_7, Rkoma2_7, RaccelZ_7, Rpar2_7] = textread('Ruben-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Rpar1_8, RaccelX_8, Rkoma1_8, RaccelY_8, Rkoma2_8, RaccelZ_8, Rpar2_8] = textread('Ruben-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Rpar1_9, RaccelX_9, Rkoma1_9, RaccelY_9, Rkoma2_9, RaccelZ_9, Rpar2_9] = textread('Ruben-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Rpar1_10, RaccelX_10, Rkoma1_10, RaccelY_10, Rkoma2_10, RaccelZ_10, Rpar2_10] = textread('Ruben-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');

[Jpar1_1, JaccelX_1, Jkoma1_1, JaccelY_1, Jkoma2_1, JaccelZ_1, Jpar2_1] = textread('Julius-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Jpar1_2, JaccelX_2, Jkoma1_2, JaccelY_2, Jkoma2_2, JaccelZ_2, Jpar2_2] = textread('Julius-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Jpar1_3, JaccelX_3, Jkoma1_3, JaccelY_3, Jkoma2_3, JaccelZ_3, Jpar2_3] = textread('Julius-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Jpar1_4, JaccelX_4, Jkoma1_4, JaccelY_4, Jkoma2_4, JaccelZ_4, Jpar2_4] = textread('Julius-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Jpar1_5, JaccelX_5, Jkoma1_5, JaccelY_5, Jkoma2_5, JaccelZ_5, Jpar2_5] = textread('Julius-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Jpar1_6, JaccelX_6, Jkoma1_6, JaccelY_6, Jkoma2_6, JaccelZ_6, Jpar2_6] = textread('Julius-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Jpar1_7, JaccelX_7, Jkoma1_7, JaccelY_7, Jkoma2_7, JaccelZ_7, Jpar2_7] = textread('Julius-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Jpar1_8, JaccelX_8, Jkoma1_8, JaccelY_8, Jkoma2_8, JaccelZ_8, Jpar2_8] = textread('Julius-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Jpar1_9, JaccelX_9, Jkoma1_9, JaccelY_9, Jkoma2_9, JaccelZ_9, Jpar2_9] = textread('Julius-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Jpar1_10, JaccelX_10, Jkoma1_10, JaccelY_10, Jkoma2_10, JaccelZ_10, Jpar2_10] = textread('Julius-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');

%% Tot Gyro

clear;
clc;
figure;
%Elin Linus MAx ruben Julius

[Epar1_11, EgyroX_1, Ekoma1_11, EgyroY_1, Ekoma2_11, EgyroZ_1, Epar2_11] = textread('Elin-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Epar1_22, EgyroX_2, Ekoma1_22, EgyroY_2, Ekoma2_22, EgyroZ_2, Epar2_22] = textread('Elin-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Epar1_33, EgyroX_3, Ekoma1_33, EgyroY_3, Ekoma2_33, EgyroZ_3, Epar2_33] = textread('Elin-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[Epar1_44, EgyroX_4, Ekoma1_44, EgyroY_4, Ekoma2_44, EgyroZ_4, Epar2_44] = textread('Elin-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[Epar1_55, EgyroX_5, Ekoma1_55, EgyroY_5, Ekoma2_55, EgyroZ_5, Epar2_55] = textread('Elin-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[Epar1_66, EgyroX_6, Ekoma1_66, EgyroY_6, Ekoma2_66, EgyroZ_6, Epar2_66] = textread('Elin-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[Epar1_77, EgyroX_7, Ekoma1_77, EgyroY_7, Ekoma2_77, EgyroZ_7, Epar2_77] = textread('Elin-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[Epar1_88, EgyroX_8, Ekoma1_88, EgyroY_8, Ekoma2_88, EgyroZ_8, Epar2_88] = textread('Elin-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[Epar1_99, EgyroX_9, Ekoma1_99, EgyroY_9, Ekoma2_99, EgyroZ_9, Epar2_99] = textread('Elin-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[Epar1_100, EgyroX_10, Ekoma1_100, EgyroY_10, Ekoma2_100, EgyroZ_10, Epar2_100] = textread('Elin-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[Lpar1_11, LgyroX_1, Lkoma1_11, LgyroY_1, Lkoma2_11, LgyroZ_1, Lpar2_11] = textread('Linus-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Lpar1_22, LgyroX_2, Lkoma1_22, LgyroY_2, Lkoma2_22, LgyroZ_2, Lpar2_22] = textread('Linus-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Lpar1_33, LgyroX_3, Lkoma1_33, LgyroY_3, Lkoma2_33, LgyroZ_3, Lpar2_33] = textread('Linus-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[Lpar1_44, LgyroX_4, Lkoma1_44, LgyroY_4, Lkoma2_44, LgyroZ_4, Lpar2_44] = textread('Linus-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[Lpar1_55, LgyroX_5, Lkoma1_55, LgyroY_5, Lkoma2_55, LgyroZ_5, Lpar2_55] = textread('Linus-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[Lpar1_66, LgyroX_6, Lkoma1_66, LgyroY_6, Lkoma2_66, LgyroZ_6, Lpar2_66] = textread('Linus-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[Lpar1_77, LgyroX_7, Lkoma1_77, LgyroY_7, Lkoma2_77, LgyroZ_7, Lpar2_77] = textread('Linus-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[Lpar1_88, LgyroX_8, Lkoma1_88, LgyroY_8, Lkoma2_88, LgyroZ_8, Lpar2_88] = textread('Linus-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[Lpar1_99, LgyroX_9, Lkoma1_99, LgyroY_9, Lkoma2_99, LgyroZ_9, Lpar2_99] = textread('Linus-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[Lpar1_100, LgyroX_10, Lkoma1_100, LgyroY_10, Lkoma2_100, LgyroZ_10, Lpar2_100] = textread('Linus-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[Mpar1_11, MgyroX_1, Mkoma1_11, MgyroY_1, Mkoma2_11, MgyroZ_1, Mpar2_11] = textread('Max-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Mpar1_22, MgyroX_2, Mkoma1_22, MgyroY_2, Mkoma2_22, MgyroZ_2, Mpar2_22] = textread('Max-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Mpar1_33, MgyroX_3, Mkoma1_33, MgyroY_3, Mkoma2_33, MgyroZ_3, Mpar2_33] = textread('Max-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[Mpar1_44, MgyroX_4, Mkoma1_44, MgyroY_4, Mkoma2_44, MgyroZ_4, Mpar2_44] = textread('Max-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[Mpar1_55, MgyroX_5, Mkoma1_55, MgyroY_5, Mkoma2_55, MgyroZ_5, Mpar2_55] = textread('Max-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[Mpar1_66, MgyroX_6, Mkoma1_66, MgyroY_6, Mkoma2_66, MgyroZ_6, Mpar2_66] = textread('Max-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[Mpar1_77, MgyroX_7, Mkoma1_77, MgyroY_7, Mkoma2_77, MgyroZ_7, Mpar2_77] = textread('Max-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[Mpar1_88, MgyroX_8, Mkoma1_88, MgyroY_8, Mkoma2_88, MgyroZ_8, Mpar2_88] = textread('Max-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[Mpar1_99, MgyroX_9, Mkoma1_99, MgyroY_9, Mkoma2_99, MgyroZ_9, Mpar2_99] = textread('Max-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[Mpar1_100, MgyroX_10, Mkoma1_100, MgyroY_10, Mkoma2_100, MgyroZ_10, Mpar2_100] = textread('Max-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[Rpar1_11, RgyroX_1, Rkoma1_11, RgyroY_1, Rkoma2_11, RgyroZ_1, Rpar2_11] = textread('Ruben-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Rpar1_22, RgyroX_2, Rkoma1_22, RgyroY_2, Rkoma2_22, RgyroZ_2, Rpar2_22] = textread('Ruben-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Rpar1_33, RgyroX_3, Rkoma1_33, RgyroY_3, Rkoma2_33, RgyroZ_3, Rpar2_33] = textread('Ruben-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[Rpar1_44, RgyroX_4, Rkoma1_44, RgyroY_4, Rkoma2_44, RgyroZ_4, Rpar2_44] = textread('Ruben-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[Rpar1_55, RgyroX_5, Rkoma1_55, RgyroY_5, Rkoma2_55, RgyroZ_5, Rpar2_55] = textread('Ruben-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[Rpar1_66, RgyroX_6, Rkoma1_66, RgyroY_6, Rkoma2_66, RgyroZ_6, Rpar2_66] = textread('Ruben-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[Rpar1_77, RgyroX_7, Rkoma1_77, RgyroY_7, Rkoma2_77, RgyroZ_7, Rpar2_77] = textread('Ruben-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[Rpar1_88, RgyroX_8, Rkoma1_88, RgyroY_8, Rkoma2_88, RgyroZ_8, Rpar2_88] = textread('Ruben-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[Rpar1_99, RgyroX_9, Rkoma1_99, RgyroY_9, Rkoma2_99, RgyroZ_9, Rpar2_99] = textread('Ruben-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[Rpar1_100, RgyroX_10, Rkoma1_100, RgyroY_10, Rkoma2_100, RgyroZ_10, Rpar2_100] = textread('Ruben-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[Jpar1_11, JgyroX_1, Jkoma1_11, JgyroY_1, Jkoma2_11, JgyroZ_1, Jpar2_11] = textread('Julius-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Jpar1_22, JgyroX_2, Jkoma1_22, JgyroY_2, Jkoma2_22, JgyroZ_2, Jpar2_22] = textread('Julius-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[Jpar1_33, JgyroX_3, Jkoma1_33, JgyroY_3, Jkoma2_33, JgyroZ_3, Jpar2_33] = textread('Julius-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[Jpar1_44, JgyroX_4, Jkoma1_44, JgyroY_4, Jkoma2_44, JgyroZ_4, Jpar2_44] = textread('Julius-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[Jpar1_55, JgyroX_5, Jkoma1_55, JgyroY_5, Jkoma2_55, JgyroZ_5, Jpar2_55] = textread('Julius-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[Jpar1_66, JgyroX_6, Jkoma1_66, JgyroY_6, Jkoma2_66, JgyroZ_6, Jpar2_66] = textread('Julius-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[Jpar1_77, JgyroX_7, Jkoma1_77, JgyroY_7, Jkoma2_77, JgyroZ_7, Jpar2_77] = textread('Julius-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[Jpar1_88, JgyroX_8, Jkoma1_88, JgyroY_8, Jkoma2_88, JgyroZ_8, Jpar2_88] = textread('Julius-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[Jpar1_99, JgyroX_9, Jkoma1_99, JgyroY_9, Jkoma2_99, JgyroZ_9, Jpar2_99] = textread('Julius-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[Jpar1_100, JgyroX_10, Jkoma1_100, JgyroY_10, Jkoma2_100, JgyroZ_10, Jpar2_100] = textread('Julius-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');


%% Plotta ut f�r varje person
%Plotta ut f�r varje person

%Scattel scatter(x,y) plotar endast punkter
t = 1:1:length(EaccelZ_4);

%Tot
Emn = (EaccelZ_1 + EaccelZ_2 + EaccelZ_3 + EaccelZ_4)./4;
Jmn = (JaccelZ_1 + JaccelZ_2 + JaccelZ_3 + JaccelZ_4)./4;
Mmn = (MaccelZ_1 + MaccelZ_2 + MaccelZ_3 + MaccelZ_4)./4;
Lmn = (LaccelZ_1 + LaccelZ_2 + LaccelZ_3 + LaccelZ_4)./4;
Rmn = (RaccelZ_1 + RaccelZ_2 + RaccelZ_3 + RaccelZ_4)./4;

Edelta = sum(abs(Emn-EaccelZ_3))/20;

figure(1);
title('Tot')
hold on;
plot(t,Emn);
plot(t,Jmn);
plot(t,Mmn);
plot(t,Lmn);
plot(t,Rmn);

legend('Elin','Julius','Max', 'Linus', 'Ruben')
hold off;

%Elin
Emn = (EaccelZ_1 + EaccelZ_2 + EaccelZ_3 + EaccelZ_4)./4;

Edelta = sum(abs(Emn-EaccelZ_3))/20;



figure(2);
title('Elin')
hold on;
plot(t,Emn+Edelta);
plot(t,Emn);
plot(t,Emn-Edelta);
legend('�vreFel','Medel','UndreFel')
hold off;


%Julius
Jmn = (JaccelZ_1 + JaccelZ_2 + JaccelZ_3 + JaccelZ_4)./4;

Jdelta = sum(abs(Jmn-JaccelZ_3))/20;


figure(3);
title('Julius')
hold on;
plot(t,Jmn+Jdelta);
plot(t,Jmn);
plot(t,Jmn-Jdelta);

legend('�vreFel','Medel','UndreFel')
hold off;


%Max
Mmn = (MaccelZ_1 + MaccelZ_2 + MaccelZ_3 + MaccelZ_4)./4;

Mdelta = sum(abs(Mmn-MaccelZ_3))/20;


figure(4);
title('Max')
hold on;
plot(t,Mmn+Mdelta);
plot(t,Mmn);
plot(t,Mmn-Mdelta);

legend('�vreFel','Medel','UndreFel')
hold off;


%Linus
Lmn = (LaccelZ_1 + LaccelZ_2 + LaccelZ_3 + LaccelZ_4)./4;

Ldelta = sum(abs(Lmn-LaccelZ_3))/20;


figure(5);
title('Linus')
hold on;
plot(t,Lmn+Ldelta);
plot(t,Lmn);
plot(t,Lmn-Ldelta);

legend('�vreFel','Medel','UndreFel')
hold off;


%Ruben
Rmn = (RaccelZ_1 + RaccelZ_2 + RaccelZ_3 + RaccelZ_4)./4;

Rdelta = sum(abs(Rmn-RaccelZ_3))/20;


figure(6);
title('Ruben')
hold on;
plot(t,Rmn+Rdelta);
plot(t,Rmn);
plot(t,Rmn-Rdelta);

legend('�vreFel','Medel','UndreFel')
hold off;

%%
%Godk�nt om ex 17/20 medelv�rden �r innanf�r ett intervall.
%Endast 3st utanf�r




%%
%Ber�kna ett totalt fel(avs�ndet fr�n varje medel).
%Om det �verstiger ett visst tal s� �r det underk�nt






%%
%J�mf�ra mot olika typer av tr�ningsformer ex �r det mest likt en squat
%eller sittups?







%%
%J�mf�r i vissa intervaller. ex i f�rsta intervallet ska det g� ner och i
%andra intervallet ska det g� upp.





%%
%Anv�nd endast gyro, accel eller b�da. Vad ger b�st resultat?




%%
%Ha andra personer som referenser och j�mf�r din m�tning mot
%Eller att du f�rst g�r n�gra ideal r�relser som du sedan j�mf�r mot.



%%
%H�ll mobilen p� olika st�llen p� kroppen (ex armen, l�ret eller h�lla i h�nderna), vad ger b�st resultat.


%%
%Vilken accel ska man j�mf�ra mot s� det blir b�st? x-accel, y-axxel,
%z-accel

%%
%Ha ljud som s�ger till n�r du ska g�ra skaker eller flytta "piken" i
%m�tningen s� att den st�mmer �verens men referenserna


%%
%Hur ska vi f� in allt i Unity?


%%
%Vilken typ av effecter ger b�st?
%Ljud, visuell eller haptic?

%% J�mf�r olika antal means. Vilket antal p� means ger b�st resultat?
%



%% Fr�gor att jobba vidare med
%D� har vi 3saker att j�mf�ra
%*Olika typer av m�tning
%*Var p� kroppen man har mobilen?
%*Hur man l�ser av. Hur man godk�nner/underk�nner
%*Vad som �r b�st motivering ex haptic, ljud eller visuell?









