a=zeros(300,300,3,'uint8');
for i =1:300
 for j=1:300
  a(i,j,1)=255;
 end
end
figure,imshow(a);
for i = 41:260
 for j=41:260
  a(i,j,2)=255;
  a(i,j,1)=0;
  a(i,j,3)=0;
 end
end
figure,imshow(a);
for i = 121:180
 for j=121:180
  a(i,j,1)=0;
  a(i,j,2)=0;
  a(i,j,3)=255;
 end
end
figure,imshow(a);

#greyscale
a=zeros(255,255,'uint8');
for i = 11:190
 for j=11:190
  a(i,j)=255;
 end
end
for i= 1:200
 a(i,i)=0;
 a(i,200-i)=0;
 a(i,i+1)=0;
 a(i+1,200-i)=0;
end
figure,imshow(a);
#from rgb to greyscal
a=imread('test1.jpg');
b=zeros(size(a,1),size(a,2),'uint8');
figure,imshow(a);
for i = 1:size(a,1)#row
 for j = 1:size(a,2)#colomn
   b(i,j)=max(a(i,j,:))/2+min(a(i,j,:))/2;
  end
 end
figure,imshow(b);
imwrite(b,'gery.png');












