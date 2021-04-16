

%%
% FÃ¶r att titta pÃ¥ datan som sparas i mobilen

clear;
clc;
%45grader

[Epar1_1, EaccelX_1, Ekoma1_1, EaccelY_1, Ekoma2_1, EaccelZ_1, Epar2_1] = textread('Testfram-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');
[Epar1_2, EaccelX_2, Ekoma1_2, EaccelY_2, Ekoma2_2, EaccelZ_2, Epar2_2] = textread('Fyrtiofemgrader-20meanGyroList-0.txt', '%c %f %c %f %c %f %c');
%[Epar1_3, EaccelX_3, Ekoma1_3, EaccelY_3, Ekoma2_3, EaccelZ_3, Epar2_3] = textread('Testdoor-20meanGyroList-0.txt', '%c %f %c %f %c %f %c');
%[Epar1_4, EaccelX_4, Ekoma1_4, EaccelY_4, Ekoma2_4, EaccelZ_4, Epar2_4] = textread('Testwall-20meanGyroList-1.txt', '%c %f %c %f %c %f %c');


t = 1:1:length(EaccelZ_1);

figure(1);
title('X-axel. Horizontell/45°')
hold on;
plot(t,EaccelX_1);
plot(t,EaccelX_2);
legend('Horisontell','45°')
hold off;

figure(2);
title('Y-axel. Horizontell/45°')
hold on;
plot(t,EaccelY_1);
plot(t,EaccelY_2);
legend('Horisontell','45°')
hold off;


figure(3);
title('Z-axel. Horizontell/45°')
hold on;
plot(t,EaccelZ_1);
plot(t,EaccelZ_2);
legend('Horisontell','45°')
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
title('X-axel. Gyro-Medelvärde')
hold on;
plot(t,EaccelX_1);
plot(t,EaccelX_2);
plot(t,EaccelX_3);
plot(t,EaccelX_4);
legend('Framåt','Höger','Backåt', 'Vänster')
hold off;

figure(2);
title('Y-axel. Gyro-Medelvärde')
hold on;
plot(t,EaccelY_1);
plot(t,EaccelY_2);
plot(t,EaccelY_3);
plot(t,EaccelY_4);
legend('Framåt','Höger','Backåt', 'Vänster')
hold off;


figure(3);
title('Z-axel. Gyro-Medelvärde')
hold on;
plot(t,EaccelZ_1);
plot(t,EaccelZ_2);
plot(t,EaccelZ_3);
plot(t,EaccelZ_4);
legend('Framåt','Höger','Backåt', 'Vänster')
hold off;
%% Medel av alla accel
clear;
clc;
figure;
[Epar1_0, EaccelX_0, Ekoma1_0, EaccelY_0, Ekoma2_0, EaccelZ_0, Epar2_0] = textread('Elin-20meanAccelList-0.txt', '%c %f %c %f %c %f %c');
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

[Lpar1_0, LaccelX_0, Lkoma1_0, LaccelY_0, Lkoma2_0, LaccelZ_0, Lpar2_0] = textread('Linus-20meanAccelList-0.txt', '%c %f %c %f %c %f %c');
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

[Mpar1_0, MaccelX_0, Mkoma1_0, MaccelY_0, Mkoma2_0, MaccelZ_0, Mpar2_0] = textread('Max-20meanAccelList-0.txt', '%c %f %c %f %c %f %c');
[Mpar1_1, MaccelX_1, Mkoma1_1, MaccelY_1, Mkoma2_1, MaccelZ_1, Mpar2_1] = textread('Max-20meanAccelList-1.txt', '%c %f %c %f %c %f %c');
[Mpar1_2, MaccelX_2, Mkoma1_2, MaccelY_2, Mkoma2_2, MaccelZ_2, Mpar2_2] = textread('Max-20meanAccelList-2.txt', '%c %f %c %f %c %f %c');
[Mpar1_3, MaccelX_3, Mkoma1_3, MaccelY_3, Mkoma2_3, MaccelZ_3, Mpar2_3] = textread('Max-20meanAccelList-3.txt', '%c %f %c %f %c %f %c');
[Mpar1_4, MaccelX_4, Mkoma1_4, MaccelY_4, Mkoma2_4, MaccelZ_4, Mpar2_4] = textread('Max-20meanAccelList-4.txt', '%c %f %c %f %c %f %c');
[Mpar1_5, MaccelX_5, Mkoma1_5, MaccelY_5, Mkoma2_5, MaccelZ_5, Mpar2_5] = textread('Max-20meanAccelList-5.txt', '%c %f %c %f %c %f %c');
[Mpar1_6, MaccelX_6, Mkoma1_6, MaccelY_6, Mkoma2_6, MaccelZ_6, Mpar2_6] = textread('Max-20meanAccelList-6.txt', '%c %f %c %f %c %f %c');
[Mpar1_7, MaccelX_7, Mkoma1_7, MaccelY_7, Mkoma2_7, MaccelZ_7, Mpar2_7] = textread('Max-20meanAccelList-7.txt', '%c %f %c %f %c %f %c');
[Mpar1_8, MaccelX_8, Mkoma1_8, MaccelY_8, Mkoma2_8, MaccelZ_8, Mpar2_8] = textread('Max-20meanAccelList-8.txt', '%c %f %c %f %c %f %c');
[Mpar1_9, MaccelX_9, Mkoma1_9, MaccelY_9, Mkoma2_9, EaccelZ_9, Epar2_9] = textread('Elin-20meanAccelList-9.txt', '%c %f %c %f %c %f %c');
[Epar1_10, EaccelX_10, Ekoma1_10, EaccelY_10, Ekoma2_10, EaccelZ_10, Epar2_10] = textread('Elin-20meanAccelList-10.txt', '%c %f %c %f %c %f %c');

[Epar1_0, EaccelX_0, Ekoma1_0, EaccelY_0, Ekoma2_0, EaccelZ_0, Epar2_0] = textread('Elin-20meanAccelList-0.txt', '%c %f %c %f %c %f %c');
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

[Epar1_0, EaccelX_0, Ekoma1_0, EaccelY_0, Ekoma2_0, EaccelZ_0, Epar2_0] = textread('Elin-20meanAccelList-0.txt', '%c %f %c %f %c %f %c');
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



%% Plotta ut för varje person
%Plotta ut för varje person

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
legend('ÖvreFel','Medel','UndreFel')
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

legend('ÖvreFel','Medel','UndreFel')
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

legend('ÖvreFel','Medel','UndreFel')
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

legend('ÖvreFel','Medel','UndreFel')
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

legend('ÖvreFel','Medel','UndreFel')
hold off;

%%
%Godkänt om ex 17/20 medelvärden är innanför ett intervall.
%Endast 3st utanför




%%
%Beräkna ett totalt fel(avsåndet från varje medel).
%Om det överstiger ett visst tal så är det underkänt






%%
%Jämföra mot olika typer av träningsformer ex är det mest likt en squat
%eller sittups?







%%
%Jämför i vissa intervaller. ex i första intervallet ska det gå ner och i
%andra intervallet ska det gå upp.





%%
%Använd endast gyro, accel eller båda. Vad ger bäst resultat?




%%
%Ha andra personer som referenser och jämför din mätning mot
%Eller att du först gör några ideal rörelser som du sedan jämför mot.



%%
%Håll mobilen på olika ställen på kroppen (ex armen, låret eller hålla i händerna), vad ger bäst resultat.


%%
%Vilken accel ska man jämföra mot så det blir bäst? x-accel, y-axxel,
%z-accel

%%
%Ha ljud som säger till när du ska göra skaker eller flytta "piken" i
%mätningen så att den stämmer överens men referenserna


%%
%Hur ska vi få in allt i Unity?


%%
%Vilken typ av effecter ger bäst?
%Ljud, visuell eller haptic?

%% Jämför olika antal means. Vilket antal på means ger bäst resultat?
%



%% Frågor att jobba vidare med
%Då har vi 3saker att jämföra
%*Olika typer av mätning
%*Var på kroppen man har mobilen?
%*Hur man läser av. Hur man godkänner/underkänner
%*Vad som är bäst motivering ex haptic, ljud eller visuell?










