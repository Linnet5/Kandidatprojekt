

%%
% För att titta på datan som sparas i mobilen


clear;
clc;



[par1, accelX, koma1, accelY, koma2, accelZ, par2] = textread('accelData.txt', '%c %f %c %f %c %f  %c');

t = 1:1:179;

plot(t,accelY);