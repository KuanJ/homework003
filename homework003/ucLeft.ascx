<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLeft.ascx.cs" Inherits="homework003.ucLeft" %>
<style>
    body {
        margin: 0;
    }

    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        width: 20%;
        background-color: #f1f1f1;
        overflow: auto;
        order: 0;
        flex-direction: row;
    }

    li a {
        display: block;
        color: #000;
        padding: 8px 16px;
        text-decoration: none;
    }

    .container {
        display: flex;
        justify-content: flex-start;
        height: 500px;
    }

    li a.active {
        background-color: #4CAF50;
        color: white;
    }

    li a:hover:not(.active) {
        background-color: #555;
        color: white;
    }
</style>
<div class="container">
    <ul>
        <li><a href="WebForm1.aspx">無人機管理</a></li>
        <li><a>new</a></li>
        <li><a href="https://www.w3schools.com/">興趣頁面</a></li>
    </ul>
</div>
