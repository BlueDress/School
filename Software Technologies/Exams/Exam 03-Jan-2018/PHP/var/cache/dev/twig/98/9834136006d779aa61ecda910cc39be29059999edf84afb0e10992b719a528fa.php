<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6e363229e7cf377bac904e5edff6428d92ed1d2dcb859d57e554e73e08fc413b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6e363229e7cf377bac904e5edff6428d92ed1d2dcb859d57e554e73e08fc413b->enter($__internal_6e363229e7cf377bac904e5edff6428d92ed1d2dcb859d57e554e73e08fc413b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_df68b447a2caaf5c4fd7edac9afd33fe06336d78268c2dec641860e5ae10eb9a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_df68b447a2caaf5c4fd7edac9afd33fe06336d78268c2dec641860e5ae10eb9a->enter($__internal_df68b447a2caaf5c4fd7edac9afd33fe06336d78268c2dec641860e5ae10eb9a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6e363229e7cf377bac904e5edff6428d92ed1d2dcb859d57e554e73e08fc413b->leave($__internal_6e363229e7cf377bac904e5edff6428d92ed1d2dcb859d57e554e73e08fc413b_prof);

        
        $__internal_df68b447a2caaf5c4fd7edac9afd33fe06336d78268c2dec641860e5ae10eb9a->leave($__internal_df68b447a2caaf5c4fd7edac9afd33fe06336d78268c2dec641860e5ae10eb9a_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_21b2a202f5b393a92e357464ce1a36afb3886de0a2d4c78e1ab1a2d429908348 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_21b2a202f5b393a92e357464ce1a36afb3886de0a2d4c78e1ab1a2d429908348->enter($__internal_21b2a202f5b393a92e357464ce1a36afb3886de0a2d4c78e1ab1a2d429908348_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_5fe381ed27a8a211a230e37f96ab414a601f63a2e7f0e3caef2d87b0c662dc68 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5fe381ed27a8a211a230e37f96ab414a601f63a2e7f0e3caef2d87b0c662dc68->enter($__internal_5fe381ed27a8a211a230e37f96ab414a601f63a2e7f0e3caef2d87b0c662dc68_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_5fe381ed27a8a211a230e37f96ab414a601f63a2e7f0e3caef2d87b0c662dc68->leave($__internal_5fe381ed27a8a211a230e37f96ab414a601f63a2e7f0e3caef2d87b0c662dc68_prof);

        
        $__internal_21b2a202f5b393a92e357464ce1a36afb3886de0a2d4c78e1ab1a2d429908348->leave($__internal_21b2a202f5b393a92e357464ce1a36afb3886de0a2d4c78e1ab1a2d429908348_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_dbdf987343375e84749b563f312e956943274e70f1ff5f9b169ead420e652615 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dbdf987343375e84749b563f312e956943274e70f1ff5f9b169ead420e652615->enter($__internal_dbdf987343375e84749b563f312e956943274e70f1ff5f9b169ead420e652615_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_2c20601cdd2f39ca726fc9aaa206162a09d1e44a2ab301c1dca8674f94b51c56 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2c20601cdd2f39ca726fc9aaa206162a09d1e44a2ab301c1dca8674f94b51c56->enter($__internal_2c20601cdd2f39ca726fc9aaa206162a09d1e44a2ab301c1dca8674f94b51c56_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_2c20601cdd2f39ca726fc9aaa206162a09d1e44a2ab301c1dca8674f94b51c56->leave($__internal_2c20601cdd2f39ca726fc9aaa206162a09d1e44a2ab301c1dca8674f94b51c56_prof);

        
        $__internal_dbdf987343375e84749b563f312e956943274e70f1ff5f9b169ead420e652615->leave($__internal_dbdf987343375e84749b563f312e956943274e70f1ff5f9b169ead420e652615_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_c517852fbef6642ffe93a760d6b5e20492b0600c0ab8173d17bbf3a4d25c2a2b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c517852fbef6642ffe93a760d6b5e20492b0600c0ab8173d17bbf3a4d25c2a2b->enter($__internal_c517852fbef6642ffe93a760d6b5e20492b0600c0ab8173d17bbf3a4d25c2a2b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_1cd64b1411ab9d757d5c666f5adb4fd751346703b37ee5939d68f5b5711a884c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1cd64b1411ab9d757d5c666f5adb4fd751346703b37ee5939d68f5b5711a884c->enter($__internal_1cd64b1411ab9d757d5c666f5adb4fd751346703b37ee5939d68f5b5711a884c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_1cd64b1411ab9d757d5c666f5adb4fd751346703b37ee5939d68f5b5711a884c->leave($__internal_1cd64b1411ab9d757d5c666f5adb4fd751346703b37ee5939d68f5b5711a884c_prof);

        
        $__internal_c517852fbef6642ffe93a760d6b5e20492b0600c0ab8173d17bbf3a4d25c2a2b->leave($__internal_c517852fbef6642ffe93a760d6b5e20492b0600c0ab8173d17bbf3a4d25c2a2b_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
