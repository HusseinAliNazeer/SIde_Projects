a=imread('cat.1.jpg');
b=imread('cat.2.jpg');
#clc: clear command window 
#clear:clear variables from workspace
#; won't print any vlues
#imshow(b);
#figure
#imshow(a);
c=a;#to acess index in 3 ch colors
sprintf('Pixel %d',c)#to print value
for i=1:280;
 for j=1:300;
  c(i,j,2)=c(i,j,2)+200;
 end;
end;
#imshow(a);
#figure;
#imshow(b);
#show two pictures
#supplot(rows,cols,image)
subplot(2,1,1);
imshow(a);
subplot(2,1,2);
imshow(c);
figure;
#graphics_toolkit("gnuplot")



