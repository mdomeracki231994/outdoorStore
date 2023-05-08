from django.urls import path
from .views import PostList, PostDetail, CommentList, CommentDetail, TagList, TagDetail, CategoryList, CategoryDetail

urlpatterns = [
    path('posts/', PostList.as_view(), name='post_list'),
    path('posts/<int:pk>/', PostDetail.as_view(), name='post_detail'),
    path('comments/', CommentList.as_view(), name='comment_list'),
    path('comments/<int:pk>/', CommentDetail.as_view(), name='comment_detail'),
    path('tags/', TagList.as_view(), name='tag_list'),
    path('tags/<int:pk>/', TagDetail.as_view(), name='tag_detail'),
    path('categories/', CategoryList.as_view(), name='category_list'),
    path('categories/<int:pk>/', CategoryDetail.as_view(), name='category_detail'),
]
