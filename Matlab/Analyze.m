

%%
% För att titta på datan som sparas i mobilen


clear;
clc;


figure;
[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread('Max-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread('Max-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread('Max-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread('Max-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_5, accelX_5, koma1_5, accelY_5, koma2_5, accelZ_5, par2_5] = textread('Max-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_6, accelX_6, koma1_6, accelY_6, koma2_6, accelZ_6, par2_6] = textread('Max-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_7, accelX_7, koma1_7, accelY_7, koma2_7, accelZ_7, par2_7] = textread('Max-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_8, accelX_8, koma1_8, accelY_8, koma2_8, accelZ_8, par2_8] = textread('Max-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_9, accelX_9, koma1_9, accelY_9, koma2_9, accelZ_9, par2_9] = textread('Max-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_10, accelX_10, koma1_10, accelY_10, koma2_10, accelZ_10, par2_10] = textread('Max-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[par1_11, accelX_11, koma1_11, accelY_11, koma2_11, accelZ_11, par2_11] = textread('Linus-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_12, accelX_12, koma1_12, accelY_12, koma2_12, accelZ_12, par2_12] = textread('Linus-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_13, accelX_13, koma1_13, accelY_13, koma2_13, accelZ_13, par2_13] = textread('Linus-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_14, accelX_14, koma1_14, accelY_14, koma2_14, accelZ_14, par2_14] = textread('Linus-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_15, accelX_15, koma1_15, accelY_15, koma2_15, accelZ_15, par2_15] = textread('Linus-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_16, accelX_16, koma1_16, accelY_16, koma2_16, accelZ_16, par2_16] = textread('Linus-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_17, accelX_17, koma1_17, accelY_17, koma2_17, accelZ_17, par2_17] = textread('Linus-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_18, accelX_18, koma1_18, accelY_18, koma2_18, accelZ_18, par2_18] = textread('Linus-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_19, accelX_19, koma1_19, accelY_19, koma2_19, accelZ_19, par2_19] = textread('Linus-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_20, accelX_20, koma1_20, accelY_20, koma2_20, accelZ_20, par2_20] = textread('Linus-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread('Julius-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread('Julius-20meanGyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread('Julius-20meanGyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread('Julius-20meanGyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread('Julius-20meanGyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread('Julius-20meanGyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread('Julius-20meanGyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread('Julius-20meanGyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread('Julius-20meanGyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread('Julius-20meanGyroList-10.txt', '%c %f %c %f %c %f %c');

t = 1:1:length(accelX_4);

mn = (abs(accelX_1) + abs(accelX_2) + abs(accelX_3) + abs(accelX_4) + abs(accelX_5) + abs(accelX_6) + abs(accelX_7) + abs(accelX_8) + abs(accelX_9) + abs(accelX_10) + abs(accelX_11) + abs(accelX_12) + abs(accelX_13) + abs(accelX_14) + abs(accelX_15) + abs(accelX_16) + abs(accelX_17) + abs(accelX_18) + abs(accelX_19) + abs(accelX_20) + abs(accelX_21) + abs(accelX_22) + abs(accelX_23) + abs(accelX_24) + abs(accelX_25) + abs(accelX_26) + abs(accelX_27) + abs(accelX_28) + abs(accelX_29) + abs(accelX_30))./30;

delta = sum(abs(mn-accelX_24))/20;
%delta = 0.09;
hold on;

scatter(t,abs(accelX_24)); 
plot(t,mn);
plot(t,mn-delta);
plot(t,mn+delta);


%% Skriv data till något

clear;
clc;

[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread('Max-20meangyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread('Max-20meangyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread('Max-20meangyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread('Max-20meangyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_5, accelX_5, koma1_5, accelY_5, koma2_5, accelZ_5, par2_5] = textread('Max-20meangyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_6, accelX_6, koma1_6, accelY_6, koma2_6, accelZ_6, par2_6] = textread('Max-20meangyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_7, accelX_7, koma1_7, accelY_7, koma2_7, accelZ_7, par2_7] = textread('Max-20meangyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_8, accelX_8, koma1_8, accelY_8, koma2_8, accelZ_8, par2_8] = textread('Max-20meangyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_9, accelX_9, koma1_9, accelY_9, koma2_9, accelZ_9, par2_9] = textread('Max-20meangyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_10, accelX_10, koma1_10, accelY_10, koma2_10, accelZ_10, par2_10] = textread('Max-20meangyroList-10.txt', '%c %f %c %f %c %f %c');

[par1_11, accelX_11, koma1_11, accelY_11, koma2_11, accelZ_11, par2_11] = textread('Linus-20meangyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_12, accelX_12, koma1_12, accelY_12, koma2_12, accelZ_12, par2_12] = textread('Linus-20meangyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_13, accelX_13, koma1_13, accelY_13, koma2_13, accelZ_13, par2_13] = textread('Linus-20meangyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_14, accelX_14, koma1_14, accelY_14, koma2_14, accelZ_14, par2_14] = textread('Linus-20meangyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_15, accelX_15, koma1_15, accelY_15, koma2_15, accelZ_15, par2_15] = textread('Linus-20meangyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_16, accelX_16, koma1_16, accelY_16, koma2_16, accelZ_16, par2_16] = textread('Linus-20meangyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_17, accelX_17, koma1_17, accelY_17, koma2_17, accelZ_17, par2_17] = textread('Linus-20meangyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_18, accelX_18, koma1_18, accelY_18, koma2_18, accelZ_18, par2_18] = textread('Linus-20meangyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_19, accelX_19, koma1_19, accelY_19, koma2_19, accelZ_19, par2_19] = textread('Linus-20meangyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_20, accelX_20, koma1_20, accelY_20, koma2_20, accelZ_20, par2_20] = textread('Linus-20meangyroList-10.txt', '%c %f %c %f %c %f %c');

[par1_21, accelX_21, koma1_21, accelY_21, koma2_21, accelZ_21, par2_21] = textread('Linus-20meangyroList-1.txt', '%c %f %c %f %c %f %c');
[par1_22, accelX_22, koma1_22, accelY_22, koma2_22, accelZ_22, par2_22] = textread('Linus-20meangyroList-2.txt', '%c %f %c %f %c %f %c');
[par1_23, accelX_23, koma1_23, accelY_23, koma2_23, accelZ_23, par2_23] = textread('Linus-20meangyroList-3.txt', '%c %f %c %f %c %f %c');
[par1_24, accelX_24, koma1_24, accelY_24, koma2_24, accelZ_24, par2_24] = textread('Linus-20meangyroList-4.txt', '%c %f %c %f %c %f %c');
[par1_25, accelX_25, koma1_25, accelY_25, koma2_25, accelZ_25, par2_25] = textread('Linus-20meangyroList-5.txt', '%c %f %c %f %c %f %c');
[par1_26, accelX_26, koma1_26, accelY_26, koma2_26, accelZ_26, par2_26] = textread('Linus-20meangyroList-6.txt', '%c %f %c %f %c %f %c');
[par1_27, accelX_27, koma1_27, accelY_27, koma2_27, accelZ_27, par2_27] = textread('Linus-20meangyroList-7.txt', '%c %f %c %f %c %f %c');
[par1_28, accelX_28, koma1_28, accelY_28, koma2_28, accelZ_28, par2_28] = textread('Linus-20meangyroList-8.txt', '%c %f %c %f %c %f %c');
[par1_29, accelX_29, koma1_29, accelY_29, koma2_29, accelZ_29, par2_29] = textread('Linus-20meangyroList-9.txt', '%c %f %c %f %c %f %c');
[par1_30, accelX_30, koma1_30, accelY_30, koma2_30, accelZ_30, par2_30] = textread('Linus-20meangyroList-10.txt', '%c %f %c %f %c %f %c');


