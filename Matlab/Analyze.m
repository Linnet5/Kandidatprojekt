

%%
% För att titta på datan som sparas i mobilen


clear;
clc;


figure;
[par1, accelX, koma1, accelY, koma2, accelZ, par2] = textread('Julius-100meangyroList-0.txt', '%c %f %c %f %c %f  %c');


t = 1:1:length(accelY);

plot(t,accelY);