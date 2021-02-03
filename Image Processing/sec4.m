#ZOOM grey
a=imread('grey.png');
b=zeros(200,200,'uint8');
for i = 1:size(a,1)
 for j = 1: size(a,2)
  b(2*i-1,2*j-1)=a(i,j);
  b(2*i-1,2*j)=a(i,j);
  b(2*i,2*j-1)=a(i,j);
  b(2*i,2*j)=a(i,j);
 end
end
figure,imshow(b),figure,imshow(a);
#zoom rgb
a=imread('test1.png');
a=imresize(a,0.5);
b=zeros(200,200,'uint8');
figure,imshow(a);
for i = 1:size(a,1)
 for j = 1: size(a,2)
  for k=1:3
  b(2*i-1,2*j-1,k)=a(i,j,k);
  b(2*i-1,2*j,k)=a(i,j,k);
  b(2*i,2*j-1,k)=a(i,j,k);
  b(2*i,2*j,k)=a(i,j,k);
  end
 end
end
figure,imshow(b);
#from greyscale to binary (B&W)
a=imread('grey.png');
b=zeros(200,200,'double');
figure,imshow(a);
for i = 1:size(a,1)
 for j = 1: size(a,2)
   if(a(i,j)>128)
    b(i,j)=1;
   else
    b(i,j)=0;
   end
 end
end
figure,imshow(b);







