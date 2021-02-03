A=zeros(256,256,'uint8');
#to make background white
for i= 1:256
 for j=1:256
  A(i,j)=255;
  end
end
# to make diagonal black lines 
for i= 1:256
 A(i,i)=0;
 A(i,257-i)=0;
end
figure,imshow(A);