#Flipping aside
a=imread('test2.jpg');
for i =1:size(a,1)
  for j = 1:size(a,2)
    b(i,size(a,2)-j+1,1:3)=a(i,j,1:3);
  endfor
endfor
imshow(a);figure,imshow(b);
#Flipping below
a=imread('test2.jpg');
for i =1:size(a,1)
  for j = 1:size(a,2)
    b(size(a,1)-i+1,j,1:3)=a(i,j,1:3);
  endfor
endfor
imshow(a);figure,imshow(b);
#transpose
a=imread('test2.jpg');
for i =1:size(a,1)
  for j = 1:size(a,2)
    b(j,i,1:3)=a(i,j,1:3);
  endfor
endfor
imshow(a);figure,imshow(b);

#Contrast
a=imread('test2.jpg');
for i =1:size(a,1)
  for j = 1:size(a,2)
    b(i,j,1:3)=a(i,j,1:3)*2;
  endfor
endfor
imshow(a);figure,imshow(b);

#Slicing
a=imread('test2.jpg');
for i =1:size(a,1)
  for j = 1:size(a,2)
    if (a(i,j,1)>120 &&a(i,j,2)>100 &&a(i,j,3)>90 )
      b(i,j,1)=a(i,j,1);
      b(i,j,2)=a(i,j,2);
      b(i,j,3)=a(i,j,3);

    else
      b(i,j,1)=0;
      b(i,j,2)=0;
      b(i,j,3)=0;
    endif
  endfor
endfor
imshow(a);figure,imshow(b);


