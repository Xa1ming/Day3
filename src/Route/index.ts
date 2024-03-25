import {createRouter,createWebHistory, RouteRecordRaw} from 'vue-router'

//path:路由路径，
//component指定需要渲染的路由地址
const routes : Array<RouteRecordRaw>=[
    {
        path:"/",
        component:()=>import('../components/HelloWorld.vue')
    },
    {
        path:"/Register",
        component:()=>import('../components/Register.vue')
    },
    {
        path:"/login",
        component:()=>import('../components/login.vue')
    },
    {
        path:"/Info",
        component:()=>import('../components/Info.vue')
    },
    {
        path:"/Update",
        component:()=>import('../components/Update.vue')
    },
    {
        path:"/Editinfo/:Id",
        component:()=>import('../components/Editinfo.vue')
    }
]
//createRouter():创建路由函数
//createWebHisstory():路由历史记录函数
const route = createRouter({
    history:createWebHistory(),
    routes
})
//导出路由
export default route;