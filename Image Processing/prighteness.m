#to increase image prightness
c=imread('test1.jpg');
imshow(c);
for i = 1:720
 for j=1:960
  for k=1:3
  c(i,j)=c(i,j,k)+50;
  end
 end
end
figure,imshow(c);
