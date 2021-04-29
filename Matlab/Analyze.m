%% Test Area

clear;
clc;

nom = '50';
gyroOrAccel = 'gyro';

midFileName = append('Max-',nom,gyroOrAccel,'List-1.txt');
% X och Z ska testas

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread(append('Julius-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread(append('Julius-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread(append('Julius-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread(append('Julius-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread(append('Julius-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread(append('Julius-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread(append('Julius-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread(append('Julius-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread(append('Julius-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread(append('Julius-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_31, accelX_31, koma1_31, accelY_31, koma2_31, accelZ_31, par2_31] = textread(append('Elin-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_32, accelX_32, koma1_32, accelY_32, koma2_32, accelZ_32, par2_32] = textread(append('Elin-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_33, accelX_33, koma1_33, accelY_33, koma2_33, accelZ_33, par2_33] = textread(append('Elin-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_34, accelX_34, koma1_34, accelY_34, koma2_34, accelZ_34, par2_34] = textread(append('Elin-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_35, accelX_35, koma1_35, accelY_35, koma2_35, accelZ_35, par2_35] = textread(append('Elin-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_36, accelX_36, koma1_36, accelY_36, koma2_36, accelZ_36, par2_36] = textread(append('Elin-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_37, accelX_37, koma1_37, accelY_37, koma2_37, accelZ_37, par2_37] = textread(append('Elin-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_38, accelX_38, koma1_38, accelY_38, koma2_38, accelZ_38, par2_38] = textread(append('Elin-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_39, accelX_39, koma1_39, accelY_39, koma2_39, accelZ_39, par2_39] = textread(append('Elin-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_40, accelX_40, koma1_40, accelY_40, koma2_40, accelZ_40, par2_40] = textread(append('Elin-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

t = 1:1:length(accelX_21);
scatter(t,accelX_21); ylim([-1;1]);



%% Gyro Elin Testar!!
% För att titta på datan som sparas i mobilen

clear;
clc;

nom = '50';
gyroOrAccel = 'meanGyro';

%Append bygger ihop strukturen på namnet, så att man kan ändra det smidigt
%midFileName = append('Elin-',nom,gyroOrAccel,'List-1.txt');

figure;
[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread(append('Max-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread(append('Max-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread(append('Max-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread(append('Max-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_5, accelX_5, koma1_5, accelY_5, koma2_5, accelZ_5, par2_5] = textread(append('Max-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_6, accelX_6, koma1_6, accelY_6, koma2_6, accelZ_6, par2_6] = textread(append('Max-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_7, accelX_7, koma1_7, accelY_7, koma2_7, accelZ_7, par2_7] = textread(append('Max-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_8, accelX_8, koma1_8, accelY_8, koma2_8, accelZ_8, par2_8] = textread(append('Max-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_9, accelX_9, koma1_9, accelY_9, koma2_9, accelZ_9, par2_9] = textread(append('Max-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_10, accelX_10, koma1_10, accelY_10, koma2_10, accelZ_10, par2_10] = textread(append('Max-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_11, accelX_11, koma1_11, accelY_11, koma2_11, accelZ_11, par2_11] = textread(append('Linus-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_12, accelX_12, koma1_12, accelY_12, koma2_12, accelZ_12, par2_12] = textread(append('Linus-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_13, accelX_13, koma1_13, accelY_13, koma2_13, accelZ_13, par2_13] = textread(append('Linus-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_14, accelX_14, koma1_14, accelY_14, koma2_14, accelZ_14, par2_14] = textread(append('Linus-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_15, accelX_15, koma1_15, accelY_15, koma2_15, accelZ_15, par2_15] = textread(append('Linus-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_16, accelX_16, koma1_16, accelY_16, koma2_16, accelZ_16, par2_16] = textread(append('Linus-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_17, accelX_17, koma1_17, accelY_17, koma2_17, accelZ_17, par2_17] = textread(append('Linus-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_18, accelX_18, koma1_18, accelY_18, koma2_18, accelZ_18, par2_18] = textread(append('Linus-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_19, accelX_19, koma1_19, accelY_19, koma2_19, accelZ_19, par2_19] = textread(append('Linus-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_20, accelX_20, koma1_20, accelY_20, koma2_20, accelZ_20, par2_20] = textread(append('Linus-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread(append('Julius-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread(append('Julius-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread(append('Julius-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread(append('Julius-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread(append('Julius-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread(append('Julius-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread(append('Julius-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread(append('Julius-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread(append('Julius-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread(append('Julius-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_31, accelX_31, koma1_31, accelY_31, koma2_31, accelZ_31, par2_31] = textread(append('Elin-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_32, accelX_32, koma1_32, accelY_32, koma2_32, accelZ_32, par2_32] = textread(append('Elin-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_33, accelX_33, koma1_33, accelY_33, koma2_33, accelZ_33, par2_33] = textread(append('Elin-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_34, accelX_34, koma1_34, accelY_34, koma2_34, accelZ_34, par2_34] = textread(append('Elin-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_35, accelX_35, koma1_35, accelY_35, koma2_35, accelZ_35, par2_35] = textread(append('Elin-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_36, accelX_36, koma1_36, accelY_36, koma2_36, accelZ_36, par2_36] = textread(append('Elin-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_37, accelX_37, koma1_37, accelY_37, koma2_37, accelZ_37, par2_37] = textread(append('Elin-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_38, accelX_38, koma1_38, accelY_38, koma2_38, accelZ_38, par2_38] = textread(append('Elin-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_39, accelX_39, koma1_39, accelY_39, koma2_39, accelZ_39, par2_39] = textread(append('Elin-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_40, accelX_40, koma1_40, accelY_40, koma2_40, accelZ_40, par2_40] = textread(append('Elin-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

%Varf�r lyser ej denna?
[par1_41, accelX_41, koma1_41, accelY_41, koma2_41, accelZ_41, par2_41] = textread(append('Ruben-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_42, accelX_42, koma1_42, accelY_42, koma2_42, accelZ_42, par2_42] = textread(append('Ruben-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_43, accelX_43, koma1_43, accelY_43, koma2_43, accelZ_43, par2_43] = textread(append('Ruben-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_44, accelX_44, koma1_44, accelY_44, koma2_44, accelZ_44, par2_44] = textread(append('Ruben-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_45, accelX_45, koma1_45, accelY_45, koma2_45, accelZ_45, par2_45] = textread(append('Ruben-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_46, accelX_46, koma1_46, accelY_46, koma2_46, accelZ_46, par2_46] = textread(append('Ruben-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_47, accelX_47, koma1_47, accelY_47, koma2_47, accelZ_47, par2_47] = textread(append('Ruben-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_48, accelX_48, koma1_48, accelY_48, koma2_48, accelZ_48, par2_48] = textread(append('Ruben-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_49, accelX_49, koma1_49, accelY_49, koma2_49, accelZ_49, par2_49] = textread(append('Ruben-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_50, accelX_50, koma1_50, accelY_50, koma2_50, accelZ_50, par2_50] = textread(append('Ruben-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

t = 1:1:length(accelX_4);

%mn = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30) + abs(accelX_31) + abs(accelX_32) + abs(accelX_33) + abs(accelX_34) + abs(accelX_35) + abs(accelX_36) + abs(accelX_37) + abs(accelX_38) + abs(accelX_39) + abs(accelX_40))/40;

mnX = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30) + abs(accelX_31) + abs(accelX_32) + abs(accelX_33) + abs(accelX_34) + abs(accelX_35) + abs(accelX_36) + abs(accelX_37) + abs(accelX_38) + abs(accelX_39) + abs(accelX_40)+ abs(accelX_41) + abs(accelX_42) + abs(accelX_43) + abs(accelX_44) + abs(accelX_45) + abs(accelX_46) + abs(accelX_47) + abs(accelX_48) + abs(accelX_49) + abs(accelX_50))/50;
mnY = (abs(accelY_1) + abs(accelY_2) + abs(accelY_3) + abs(accelY_4) + abs(accelY_5) + abs(accelY_6) + abs(accelY_7) + abs(accelY_8) + abs(accelY_9) + abs(accelY_10) + abs(accelY_11) + abs(accelY_12) + abs(accelY_13) + abs(accelY_14) + abs(accelY_15) + abs(accelY_16) + abs(accelY_17) + abs(accelY_18) + abs(accelY_19) + abs(accelY_20) + abs(accelY_21) + abs(accelY_22) + abs(accelY_23) + abs(accelY_24) + abs(accelY_25) + abs(accelY_26) + abs(accelY_27) + abs(accelY_28) + abs(accelY_29) + abs(accelY_30) + abs(accelY_31) + abs(accelY_32) + abs(accelY_33) + abs(accelY_34) + abs(accelY_35) + abs(accelY_36) + abs(accelY_37) + abs(accelY_38) + abs(accelY_39) + abs(accelY_40)+ abs(accelY_41) + abs(accelY_42) + abs(accelY_43) + abs(accelY_44) + abs(accelY_45) + abs(accelY_46) + abs(accelY_47) + abs(accelY_48) + abs(accelY_49) + abs(accelY_50))/50;
mnZ = (abs(accelZ_1) + abs(accelZ_2) + abs(accelZ_3) + abs(accelZ_4) + abs(accelZ_5) + abs(accelZ_6) + abs(accelZ_7) + abs(accelZ_8) + abs(accelZ_9) + abs(accelZ_10) + abs(accelZ_11) + abs(accelZ_12) + abs(accelZ_13) + abs(accelZ_14) + abs(accelZ_15) + abs(accelZ_16) + abs(accelZ_17) + abs(accelZ_18) + abs(accelZ_19) + abs(accelZ_20) + abs(accelZ_21) + abs(accelZ_22) + abs(accelZ_23) + abs(accelZ_24) + abs(accelZ_25) + abs(accelZ_26) + abs(accelZ_27) + abs(accelZ_28) + abs(accelZ_29) + abs(accelZ_30) + abs(accelZ_31) + abs(accelZ_32) + abs(accelZ_33) + abs(accelZ_34) + abs(accelZ_35) + abs(accelZ_36) + abs(accelZ_37) + abs(accelZ_38) + abs(accelZ_39) + abs(accelZ_40)+ abs(accelZ_41) + abs(accelZ_42) + abs(accelZ_43) + abs(accelZ_44) + abs(accelZ_45) + abs(accelZ_46) + abs(accelZ_47) + abs(accelZ_48) + abs(accelZ_49) + abs(accelZ_50))/50;

mnTOT(:,1) = mnX;
mnTOT(:,2) = mnY;
mnTOT(:,3) = mnZ;

%FID = fopen('meanReferenceGyro.txt', 'w');
%fprintf(FID,'%0.4f %1.4f %1.4f\n',mnTOT);

delta = sum(abs(mnX-abs(accelX_33)))/50;
%delta = 0.09;
hold on;

scatter(t,abs(accelX_33)); 
plot(t,mnX); ylim([-1,1]);
%plot(t,mnY-delta);
%plot(t,mnY+delta);

%Delta= 0.1251


%% Gyro
% För att titta på datan som sparas i mobilen

clear;
clc;

nom = '20';
gyroOrAccel = 'meanGyro';

%Append bygger ihop strukturen på namnet, så att man kan ändra det smidigt
%midFileName = append('Elin-',nom,gyroOrAccel,'List-1.txt');

figure;
[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread(append('Max-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread(append('Max-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread(append('Max-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread(append('Max-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_5, accelX_5, koma1_5, accelY_5, koma2_5, accelZ_5, par2_5] = textread(append('Max-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_6, accelX_6, koma1_6, accelY_6, koma2_6, accelZ_6, par2_6] = textread(append('Max-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_7, accelX_7, koma1_7, accelY_7, koma2_7, accelZ_7, par2_7] = textread(append('Max-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_8, accelX_8, koma1_8, accelY_8, koma2_8, accelZ_8, par2_8] = textread(append('Max-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_9, accelX_9, koma1_9, accelY_9, koma2_9, accelZ_9, par2_9] = textread(append('Max-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_10, accelX_10, koma1_10, accelY_10, koma2_10, accelZ_10, par2_10] = textread(append('Max-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_11, accelX_11, koma1_11, accelY_11, koma2_11, accelZ_11, par2_11] = textread(append('Linus-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_12, accelX_12, koma1_12, accelY_12, koma2_12, accelZ_12, par2_12] = textread(append('Linus-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_13, accelX_13, koma1_13, accelY_13, koma2_13, accelZ_13, par2_13] = textread(append('Linus-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_14, accelX_14, koma1_14, accelY_14, koma2_14, accelZ_14, par2_14] = textread(append('Linus-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_15, accelX_15, koma1_15, accelY_15, koma2_15, accelZ_15, par2_15] = textread(append('Linus-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_16, accelX_16, koma1_16, accelY_16, koma2_16, accelZ_16, par2_16] = textread(append('Linus-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_17, accelX_17, koma1_17, accelY_17, koma2_17, accelZ_17, par2_17] = textread(append('Linus-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_18, accelX_18, koma1_18, accelY_18, koma2_18, accelZ_18, par2_18] = textread(append('Linus-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_19, accelX_19, koma1_19, accelY_19, koma2_19, accelZ_19, par2_19] = textread(append('Linus-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_20, accelX_20, koma1_20, accelY_20, koma2_20, accelZ_20, par2_20] = textread(append('Linus-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread(append('Julius-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread(append('Julius-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread(append('Julius-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread(append('Julius-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread(append('Julius-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread(append('Julius-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread(append('Julius-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread(append('Julius-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread(append('Julius-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread(append('Julius-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_31, accelX_31, koma1_31, accelY_31, koma2_31, accelZ_31, par2_31] = textread(append('Elin-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_32, accelX_32, koma1_32, accelY_32, koma2_32, accelZ_32, par2_32] = textread(append('Elin-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_33, accelX_33, koma1_33, accelY_33, koma2_33, accelZ_33, par2_33] = textread(append('Elin-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_34, accelX_34, koma1_34, accelY_34, koma2_34, accelZ_34, par2_34] = textread(append('Elin-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_35, accelX_35, koma1_35, accelY_35, koma2_35, accelZ_35, par2_35] = textread(append('Elin-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_36, accelX_36, koma1_36, accelY_36, koma2_36, accelZ_36, par2_36] = textread(append('Elin-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_37, accelX_37, koma1_37, accelY_37, koma2_37, accelZ_37, par2_37] = textread(append('Elin-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_38, accelX_38, koma1_38, accelY_38, koma2_38, accelZ_38, par2_38] = textread(append('Elin-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_39, accelX_39, koma1_39, accelY_39, koma2_39, accelZ_39, par2_39] = textread(append('Elin-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_40, accelX_40, koma1_40, accelY_40, koma2_40, accelZ_40, par2_40] = textread(append('Elin-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

t = 1:1:length(accelX_4);

%mn = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30) + abs(accelX_31) + abs(accelX_32) + abs(accelX_33) + abs(accelX_34) + abs(accelX_35) + abs(accelX_36) + abs(accelX_37) + abs(accelX_38) + abs(accelX_39) + abs(accelX_40))/40;

mnX = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30) + abs(accelX_31) + abs(accelX_32) + abs(accelX_33) + abs(accelX_34) + abs(accelX_35) + abs(accelX_36) + abs(accelX_37) + abs(accelX_38) + abs(accelX_39) + abs(accelX_40))/40;
mnY = (abs(accelY_1) + abs(accelY_2) + abs(accelY_3) + abs(accelY_4) + abs(accelY_5) + abs(accelY_6) + abs(accelY_7) + abs(accelY_8) + abs(accelY_9) + abs(accelY_10) + abs(accelY_11) + abs(accelY_12) + abs(accelY_13) + abs(accelY_14) + abs(accelY_15) + abs(accelY_16) + abs(accelY_17) + abs(accelY_18) + abs(accelY_19) + abs(accelY_20) + abs(accelY_21) + abs(accelY_22) + abs(accelY_23) + abs(accelY_24) + abs(accelY_25) + abs(accelY_26) + abs(accelY_27) + abs(accelY_28) + abs(accelY_29) + abs(accelY_30) + abs(accelY_31) + abs(accelY_32) + abs(accelY_33) + abs(accelY_34) + abs(accelY_35) + abs(accelY_36) + abs(accelY_37) + abs(accelY_38) + abs(accelY_39) + abs(accelY_40))/40;
mnZ = (abs(accelZ_1) + abs(accelZ_2) + abs(accelZ_3) + abs(accelZ_4) + abs(accelZ_5) + abs(accelZ_6) + abs(accelZ_7) + abs(accelZ_8) + abs(accelZ_9) + abs(accelZ_10) + abs(accelZ_11) + abs(accelZ_12) + abs(accelZ_13) + abs(accelZ_14) + abs(accelZ_15) + abs(accelZ_16) + abs(accelZ_17) + abs(accelZ_18) + abs(accelZ_19) + abs(accelZ_20) + abs(accelZ_21) + abs(accelZ_22) + abs(accelZ_23) + abs(accelZ_24) + abs(accelZ_25) + abs(accelZ_26) + abs(accelZ_27) + abs(accelZ_28) + abs(accelZ_29) + abs(accelZ_30) + abs(accelZ_31) + abs(accelZ_32) + abs(accelZ_33) + abs(accelZ_34) + abs(accelZ_35) + abs(accelZ_36) + abs(accelZ_37) + abs(accelZ_38) + abs(accelZ_39) + abs(accelZ_40))/40;

mnTOT(:,1) = mnX;
mnTOT(:,2) = mnY;
mnTOT(:,3) = mnZ;

%FID = fopen('meanReferenceGyro.txt', 'w');
%fprintf(FID,'%0.4f %1.4f %1.4f\n',mnTOT);

delta = sum(abs(mnY-abs(accelY_33)))/20;
%delta = 0.09;
hold on;

scatter(t,abs(accelY_33)); 
plot(t,mnY); ylim([0,1]);
%plot(t,mnY-delta);
%plot(t,mnY+delta);


%% Accel
% För att titta på datan som sparas i mobilen

clear;
clc;

nom = '50';
gyroOrAccel = 'meanGyro';

%Append bygger ihop strukturen på namnet, så att man kan ändra det smidigt
%midFileName = append('Elin-',nom,gyroOrAccel,'List-1.txt');

figure;
[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread(append('Max-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread(append('Max-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread(append('Max-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread(append('Max-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_5, accelX_5, koma1_5, accelY_5, koma2_5, accelZ_5, par2_5] = textread(append('Max-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_6, accelX_6, koma1_6, accelY_6, koma2_6, accelZ_6, par2_6] = textread(append('Max-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_7, accelX_7, koma1_7, accelY_7, koma2_7, accelZ_7, par2_7] = textread(append('Max-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_8, accelX_8, koma1_8, accelY_8, koma2_8, accelZ_8, par2_8] = textread(append('Max-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_9, accelX_9, koma1_9, accelY_9, koma2_9, accelZ_9, par2_9] = textread(append('Max-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_10, accelX_10, koma1_10, accelY_10, koma2_10, accelZ_10, par2_10] = textread(append('Max-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_11, accelX_11, koma1_11, accelY_11, koma2_11, accelZ_11, par2_11] = textread(append('Linus-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_12, accelX_12, koma1_12, accelY_12, koma2_12, accelZ_12, par2_12] = textread(append('Linus-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_13, accelX_13, koma1_13, accelY_13, koma2_13, accelZ_13, par2_13] = textread(append('Linus-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_14, accelX_14, koma1_14, accelY_14, koma2_14, accelZ_14, par2_14] = textread(append('Linus-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_15, accelX_15, koma1_15, accelY_15, koma2_15, accelZ_15, par2_15] = textread(append('Linus-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_16, accelX_16, koma1_16, accelY_16, koma2_16, accelZ_16, par2_16] = textread(append('Linus-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_17, accelX_17, koma1_17, accelY_17, koma2_17, accelZ_17, par2_17] = textread(append('Linus-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_18, accelX_18, koma1_18, accelY_18, koma2_18, accelZ_18, par2_18] = textread(append('Linus-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_19, accelX_19, koma1_19, accelY_19, koma2_19, accelZ_19, par2_19] = textread(append('Linus-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_20, accelX_20, koma1_20, accelY_20, koma2_20, accelZ_20, par2_20] = textread(append('Linus-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread(append('Julius-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread(append('Julius-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread(append('Julius-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread(append('Julius-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread(append('Julius-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread(append('Julius-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread(append('Julius-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread(append('Julius-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread(append('Julius-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread(append('Julius-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_31, accelX_31, koma1_31, accelY_31, koma2_31, accelZ_31, par2_31] = textread(append('Elin-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_32, accelX_32, koma1_32, accelY_32, koma2_32, accelZ_32, par2_32] = textread(append('Elin-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_33, accelX_33, koma1_33, accelY_33, koma2_33, accelZ_33, par2_33] = textread(append('Elin-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_34, accelX_34, koma1_34, accelY_34, koma2_34, accelZ_34, par2_34] = textread(append('Elin-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_35, accelX_35, koma1_35, accelY_35, koma2_35, accelZ_35, par2_35] = textread(append('Elin-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_36, accelX_36, koma1_36, accelY_36, koma2_36, accelZ_36, par2_36] = textread(append('Elin-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_37, accelX_37, koma1_37, accelY_37, koma2_37, accelZ_37, par2_37] = textread(append('Elin-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_38, accelX_38, koma1_38, accelY_38, koma2_38, accelZ_38, par2_38] = textread(append('Elin-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_39, accelX_39, koma1_39, accelY_39, koma2_39, accelZ_39, par2_39] = textread(append('Elin-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_40, accelX_40, koma1_40, accelY_40, koma2_40, accelZ_40, par2_40] = textread(append('Elin-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

[par1_41, accelX_41, koma1_41, accelY_41, koma2_41, accelZ_41, par2_41] = textread(append('Ruben-',nom,gyroOrAccel,'List-1.txt'), '%c %f %c %f %c %f %c');
[par1_42, accelX_42, koma1_42, accelY_42, koma2_42, accelZ_42, par2_42] = textread(append('Ruben-',nom,gyroOrAccel,'List-2.txt'), '%c %f %c %f %c %f %c');
[par1_43, accelX_43, koma1_43, accelY_43, koma2_43, accelZ_43, par2_43] = textread(append('Ruben-',nom,gyroOrAccel,'List-3.txt'), '%c %f %c %f %c %f %c');
[par1_44, accelX_44, koma1_44, accelY_44, koma2_44, accelZ_44, par2_44] = textread(append('Ruben-',nom,gyroOrAccel,'List-4.txt'), '%c %f %c %f %c %f %c');
[par1_45, accelX_45, koma1_45, accelY_45, koma2_45, accelZ_45, par2_45] = textread(append('Ruben-',nom,gyroOrAccel,'List-5.txt'), '%c %f %c %f %c %f %c');
[par1_46, accelX_46, koma1_46, accelY_46, koma2_46, accelZ_46, par2_46] = textread(append('Ruben-',nom,gyroOrAccel,'List-6.txt'), '%c %f %c %f %c %f %c');
[par1_47, accelX_47, koma1_47, accelY_47, koma2_47, accelZ_47, par2_47] = textread(append('Ruben-',nom,gyroOrAccel,'List-7.txt'), '%c %f %c %f %c %f %c');
[par1_48, accelX_48, koma1_48, accelY_48, koma2_48, accelZ_48, par2_48] = textread(append('Ruben-',nom,gyroOrAccel,'List-8.txt'), '%c %f %c %f %c %f %c');
[par1_49, accelX_49, koma1_49, accelY_49, koma2_49, accelZ_49, par2_49] = textread(append('Ruben-',nom,gyroOrAccel,'List-9.txt'), '%c %f %c %f %c %f %c');
[par1_50, accelX_50, koma1_50, accelY_50, koma2_50, accelZ_50, par2_50] = textread(append('Ruben-',nom,gyroOrAccel,'List-10.txt'), '%c %f %c %f %c %f %c');

t = 1:1:length(accelX_4);

%mn = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30) + abs(accelX_31) + abs(accelX_32) + abs(accelX_33) + abs(accelX_34) + abs(accelX_35) + abs(accelX_36) + abs(accelX_37) + abs(accelX_38) + abs(accelX_39) + abs(accelX_40))/40;

mnX = (accelX_1 + accelX_2 + accelX_3 + accelX_4 + accelX_5 + accelX_6 + accelX_7 + accelX_8 + accelX_9 + accelX_10 + accelX_11 + accelX_12 + accelX_13 + accelX_14 + accelX_15 + accelX_16 + accelX_17 + accelX_18 + accelX_19 + accelX_20 + accelX_21 + accelX_22 + accelX_23 + accelX_24 + accelX_25 + accelX_26 + accelX_27 + accelX_28 + accelX_29 + accelX_30 + accelX_31 + accelX_32 + accelX_33 + accelX_34 + accelX_35 + accelX_36 + accelX_37 + accelX_38 + accelX_39 + accelX_40 + accelX_41 + accelX_42 + accelX_43 + accelX_44 + accelX_45 + accelX_46 + accelX_47 + accelX_48 + accelX_49 + accelX_50)/50;
mnY = (accelY_1 + accelY_2 + accelY_3 + accelY_4 + accelY_5 + accelY_6 + accelY_7 + accelY_8 + accelY_9 + accelY_10 + accelY_11 + accelY_12 + accelY_13 + accelY_14 + accelY_15 + accelY_16 + accelY_17 + accelY_18 + accelY_19 + accelY_20 + accelY_21 + accelY_22 + accelY_23 + accelY_24 + accelY_25 + accelY_26 + accelY_27 + accelY_28 + accelY_29 + accelY_30 + accelY_31 + accelY_32 + accelY_33 + accelY_34 + accelY_35 + accelY_36 + accelY_37 + accelY_38 + accelY_39 + accelY_40 + accelY_41 + accelY_42 + accelY_43 + accelY_44 + accelY_45 + accelY_46 + accelY_47 + accelY_48 + accelY_49 + accelY_50)/50;
mnZ = (accelZ_1 + accelZ_2 + accelZ_3 + accelZ_4 + accelZ_5 + accelZ_6 + accelZ_7 + accelZ_8 + accelZ_9 + accelZ_10 + accelZ_11 + accelZ_12 + accelZ_13 + accelZ_14 + accelZ_15 + accelZ_16 + accelZ_17 + accelZ_18 + accelZ_19 + accelZ_20 + accelZ_21 + accelZ_22 + accelZ_23 + accelZ_24 + accelZ_25 + accelZ_26 + accelZ_27 + accelZ_28 + accelZ_29 + accelZ_30 + accelZ_31 + accelZ_32 + accelZ_33 + accelZ_34 + accelZ_35 + accelZ_36 + accelZ_37 + accelZ_38 + accelZ_39 + accelZ_40 + accelZ_41 + accelZ_42 + accelZ_43 + accelZ_44 + accelZ_45 + accelZ_46 + accelZ_47 + accelZ_48 + accelZ_49 + accelZ_50)/50;





[par1_51, accelX_51, koma1_51, accelY_51, koma2_51, accelZ_51, par2_51] = textread(append('Elinfel-50meanGyroList-12.txt'), '%c %f %c %f %c %f %c');

%delta = 0.35;
hold on;
theRecMax = max(abs(min(accelY_50)),max(accelY_50));
accelY_50 = accelY_50 * (1/theRecMax);

theRefXMax = max(abs(min(mnX)),max(mnX));
mnX = mnX * (1/theRefXMax);

theRefYMax = max(abs(min(mnY)),max(mnY));
mnY = mnY * (1/theRefYMax);

theRefZMax = max(abs(min(mnZ)),max(mnZ));
mnZ = mnZ * (1/theRefZMax);

delta = sum(abs(mnY-accelY_50))/50;
scatter(t,accelY_50); ylim([-1,1]);
plot(t,mnZ);
%plot(t,mnX-delta);
%plot(t,mnX+delta);

mnTOT(:,1) = mnX;
mnTOT(:,2) = mnY;
mnTOT(:,3) = mnZ;

%FID = fopen('meanReferenceGyro.txt', 'w');
%fprintf(FID,'%0.4f %1.4f %1.4f\n',mnTOT);
