<template>
    <h3>显示学生信息</h3>
    <table border="1">
        <thead>
            <tr>
                <td>编号</td>
                <td>姓名</td>
                <td>性别</td>
                <td>年龄</td>
                <td>地址</td>
                <td>手机号</td>
                <td>操作</td>
            </tr>
        </thead>
        <tbody>
            <tr v-for="item in arr">
                <td>{{item.Id}}</td>
                <td>{{item.Name}}</td>
                <td>{{item.Sex}}</td>
                <td>{{item.Age}}</td>
                <td>{{item.Address}}</td>
                <td>{{item.Phone}}</td>
                <td><a @click="Editinfo(item.Id)" href="#">编辑</a></td>
            </tr>
        </tbody>
    </table>
    <span></span>
</template>
<script setup lang="ts">
import {ref}  from 'vue';
import { useRouter } from 'vue-router';
//useRouter 路由操作对象 只写对象
//useRoute 路由信息对象 
const router = useRouter();
 const info = ref([

 ]);
 const Editinfo = (Id:number) =>{
    //push()根据写入的路由地址，会自动寻址;
    //router.push("/Editinfo")
    router.push({
        //方式一
         path:"Editinfo/:Id",
         query:{
             Id:Id,
        }
        //方式二
        // name:"Editinfo",
        // params:{
        //     Id:Id,
        // }
    })
 };
const arr = ([
    {
        Id:1,
        Name:"张三",
        Sex:"男",
        Age:23,
        Address:"天津市",
        Phone:"13564564532",
    },
    {
        Id:2,
        Name:"李四",
        Sex:"男",
        Age:32,
        Address:"房山区",
        Phone:"13564654532",
    },
     {
        Id:3,
        Name:"小白",
        Sex:"女",
        Age:23,
        Address:"朝阳区",
        Phone:"13564654532",
    },
])
</script>