/**
 * Created by JetBrains WebStorm.
 * User: lars.roald
 * Date: 16.06.11
 * Time: 21:46
 * To change this template use File | Settings | File Templates.
 */

namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldPresenter = function ()
{
    function _activate (region)
    {
        		$("#" + region).html("<p>Hello World</p>");

    }

    return
    {
        Activate = _activate;
    }

}
