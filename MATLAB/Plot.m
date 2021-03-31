[n, c, d] = textread('Ideal1.txt', '%f %c %.9f');
[n_1, c_1, d_1] = textread('Test1.txt', '%f %c %.9f');

dec_ideal = vpa(d) ./ 10^9;
ideal_0_num = n + vpa(dec_ideal);

dec_test = vpa(d_1) ./ 10^9;
test_0_num = n_1 + vpa(dec_test);

t_ideal = 1:1:length(ideal_0_num);
plot(t_ideal, ideal_0_num(:,1));

figure;

t_test = 1:1:length(test_0_num);
plot(t_test, test_0_num(:,1));











