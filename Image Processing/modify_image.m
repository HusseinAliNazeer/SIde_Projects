function modify_image(image,R,G,B)
im=imread(image)
imshow(image)
for i=1:280;
 for j=1:300;
  im(i,j,2)=im(i,j,2)+R;
  im(i,j,2)=im(i,j,2)+G;
  im(i,j,2)=im(i,j,2)+B;
 end;
end;
imshow(image);
endfunction;