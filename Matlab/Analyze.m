

%%
% För att titta på datan som sparas i mobilen


clear;
clc;


figure;
[par1_1, accelX_1, koma1_1, accelY_1, koma2_1, accelZ_1, par2_1] = textread('Julius-20meanaccelList-1.txt', '%c %f %c %f %c %f %c');
[par1_2, accelX_2, koma1_2, accelY_2, koma2_2, accelZ_2, par2_2] = textread('Julius-20meanaccelList-2.txt', '%c %f %c %f %c %f %c');
[par1_3, accelX_3, koma1_3, accelY_3, koma2_3, accelZ_3, par2_3] = textread('Julius-20meanaccelList-3.txt', '%c %f %c %f %c %f %c');
[par1_4, accelX_4, koma1_4, accelY_4, koma2_4, accelZ_4, par2_4] = textread('Julius-20meanaccelList-4.txt', '%c %f %c %f %c %f %c');


t = 1:1:length(accelZ_4);

mn = (accelZ_1 + accelZ_2 + accelZ_3 + accelZ_4)./4;

delta = sum(abs(mn-accelZ_3))/20;

hold on;
plot(t,mn);
plot(t,mn-delta);
plot(t,mn+delta);