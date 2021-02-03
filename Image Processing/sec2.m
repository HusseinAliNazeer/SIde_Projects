#Intialize Image 
%1-Intialize the size of image 
%GreyScale
A=zeros(256,256,'uint8');
for i= 1:256
 for j=1:256
  A(i,j)=255;
  end
end
for i= 1:256
 A(i,i)=0;
 A(i,257-i)=0;
end
figure,imshow(A);
#RGB
A=zeros(256,256,3,'uint8');
for i= 1:256
 for j=1:256
  A(i,j,1)=0;
  A(i,j,2)=0;
  A(i,j,3)=256-j;
 end
end
figure,imshow(A);